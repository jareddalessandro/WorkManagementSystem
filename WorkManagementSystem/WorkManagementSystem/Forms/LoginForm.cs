using Microsoft.VisualBasic.ApplicationServices;
using System.Globalization;
using WorkManagementSystem.Forms;
using WorkManagementSystem.Models;
using WorkManagementSystem.Utils;


namespace WorkManagementSystem
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        LoginUser loginUser = new LoginUser();
        DataHandler dataHandler = new DataHandler();

        public LoginForm()
        {
            InitializeComponent();
            loginUser.TimeZone = GetUserTimeZone();
            loginUser.Location = GetUserRegion();

            switch (loginUser.Location)
            {
                case "United States":
                    translateToEnglish();
                    break;
                case "Mexico":
                    translateToSpanish();
                    break;
                case "France":
                    translateToFrench();
                    break;

                default:
                    translateToEnglish();
                    break;
            }
            txtLocationTag.Text = txtLocationTag.Text + loginUser.Location;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginUser.Password = txtPassword.Text;
            loginUser.UserName = txtUsername.Text;
            loginUser.UserId = dataHandler.ValidateUser(loginUser.UserName, loginUser.Password);

            if (loginUser.UserId != -1)
            {
                txtLoginError.Visible = false;
                LogLogin(loginUser.UserName);
                HomePage homePage = new HomePage(loginUser);
                homePage.Show();
                this.Hide();
                if (dataHandler.HasUpcomingAppointment(loginUser.UserId))
                {
                    MessageBox.Show("Alert! You have an appointment within 15 minutes of now.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                txtLoginError.Visible = true;
            }
        }

        private string GetUserTimeZone()
        {
            TimeZoneInfo localZone = System.TimeZoneInfo.Local;
            return localZone.StandardName; // Gets the system's time zone name
        }

        public string GetUserRegion()
        {
            return RegionInfo.CurrentRegion.EnglishName;
        }

        public void translateToEnglish()
        {
            txtLoginError.Text = "Error: The Username or Password is invalid!";
            usernameLabel.Text = "User Name:";
            passwordLabel.Text = "Password:";
            loginLabel.Text = "Login";
            btnLogin.Text = "Login";
            txtLocationTag.Text = "Location:";
        }

        public void translateToSpanish()
        {
            txtLoginError.Text = "Error: ¡El nombre de usuario o la contraseña no son válidos!";
            usernameLabel.Text = "Nombre de usuario:";
            passwordLabel.Text = "Contraseña:";
            loginLabel.Text = "Iniciar sesión";
            btnLogin.Text = "Iniciar sesión";
            txtLocationTag.Text = "Ubicación:";
        }
        public void translateToFrench()
        {
            txtLoginError.Text = "Erreur : Le nom d'utilisateur ou le mot de passe est invalide !";
            usernameLabel.Text = "Nom d'utilisateur :";
            passwordLabel.Text = "Mot de passe :";
            loginLabel.Text = "Connexion";
            btnLogin.Text = "Connexion";
            txtLocationTag.Text = "Emplacement :";
        }

        private void LogLogin(string username)
        {
            // Define the file path for the log (placing it in the root directory)
            string filePath = @"..\..\..\Login_History.txt";

            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            
            string logEntry = $"User: {username}, Login Time: {timestamp}";

            // Append the log entry to the file
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true)) 
                {
                    sw.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging login information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
