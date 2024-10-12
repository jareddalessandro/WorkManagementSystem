using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkManagementSystem.Models;
using WorkManagementSystem.Utils;

namespace WorkManagementSystem.Forms
{
    public partial class AddOrUpdateAppointment : Form
    {
        LoginUser _loginUser;
        DataHandler DataHandler = new DataHandler();
        Appointment _existingAppointment;
        public AddOrUpdateAppointment(LoginUser user)
        {
            InitializeComponent();
            LoadCustomerComboBox();
            _loginUser = user;
        }

        public AddOrUpdateAppointment(LoginUser user, Appointment existingAppointment)
        {
            InitializeComponent();
            LoadCustomerComboBox();
            _existingAppointment = existingAppointment;
            startDatePicker.Value = _existingAppointment.Start;
            endDatePicker.Value = _existingAppointment.End;
            txtTitle.Text = _existingAppointment.Title;
            txtDescription.Text = _existingAppointment.Description;
            txtType.Text = _existingAppointment.Type;
            txtLocation.Text = _existingAppointment.Location;
            txtContact.Text = _existingAppointment.Contact;
            txtUrl.Text = _existingAppointment.Url;
            comboCustomer.SelectedValue = _existingAppointment.CustomerId;
            _loginUser = user;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Convert from UTC to EST
        private DateTime adjustTimeEST(DateTime dateTime)
        {
            return dateTime.AddHours(-5);
        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            // NOTE Convert to UTC first for the saving to db...

            // Update existing appointment
            if (_existingAppointment != null)
            {
                Appointment appointment = new Appointment();
                try
                {
                    appointment.CustomerId = Convert.ToInt32(comboCustomer.SelectedValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Please select a customer.");
                    return;
                }
                appointment.Start = ConvertLocalToUtc(startDatePicker.Value);
                appointment.End = ConvertLocalToUtc(endDatePicker.Value);
                appointment.Title = txtTitle.Text;
                appointment.Description = txtDescription.Text;
                appointment.Type = txtType.Text;
                appointment.Contact = txtContact.Text;
                appointment.Url = txtUrl.Text;
                appointment.Location = txtLocation.Text;
                appointment.CustomerId = Convert.ToInt32(comboCustomer.SelectedValue);
                appointment.UserId = _existingAppointment.UserId;
                appointment.CreateDate = ConvertLocalToUtc(_existingAppointment.CreateDate);
                appointment.LastUpdate = DateTime.UtcNow;
                appointment.CreatedBy = _existingAppointment.CreatedBy;
                appointment.LastUpdateBy = _loginUser.UserName;
                appointment.AppointmentId = _existingAppointment.AppointmentId;

                if (DataHandler.IsAppointmentOverlapping(appointment.Start, appointment.End, appointment.AppointmentId))
                {
                    MessageBox.Show("Error: Appointments can not overlap. ");
                    return;
                }
                if (appointment.End < appointment.Start)
                {
                    MessageBox.Show("Error: end date must be after start date. ");
                    return;
                }
                if (appointment.Start.DayOfWeek == DayOfWeek.Sunday || appointment.Start.DayOfWeek == DayOfWeek.Sunday ||
                    appointment.End.DayOfWeek == DayOfWeek.Sunday || appointment.End.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("Error: Appointment must be between Mon-Fri 9:00am to 5:00pm EST");
                    return;
                }

                DateTime estStart = ConvertUtcToEST(appointment.Start);
                DateTime estEnd = ConvertUtcToEST(appointment.End);

                if (estStart.Hour < 9 || estStart.Hour >= 17 || estEnd.Hour < 9 || estEnd.Hour > 17)
                {
                    MessageBox.Show("Error: Appointment must be between Mon-Fri 9:00am to 5:00pm EST");
                    return;
                }
                if (appointment.Type.Length < 1 || appointment.Title.Length < 1)
                {
                    MessageBox.Show("Error: Please enter a Title and a Type.");
                    return;
                }

                DataHandler.UpdateAppointment(appointment);
                MessageBox.Show("Appointment Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            // New Appointment
            else 
            {
                Appointment appointment = new Appointment();
                try
                {
                    appointment.CustomerId = Convert.ToInt32(comboCustomer.SelectedValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Please select a customer.");
                    return;
                }
                appointment.Start = ConvertLocalToUtc(startDatePicker.Value);
                appointment.End = ConvertLocalToUtc(endDatePicker.Value);
                appointment.Title = txtTitle.Text;
                appointment.Description = txtDescription.Text;
                appointment.Type = txtType.Text;
                appointment.Contact = txtContact.Text;
                appointment.Url = txtUrl.Text;
                appointment.Location = txtLocation.Text;
                appointment.CustomerId = Convert.ToInt32(comboCustomer.SelectedValue);
                appointment.UserId = _loginUser.UserId;
                appointment.CreateDate = DateTime.UtcNow;
                appointment.LastUpdate = DateTime.UtcNow;
                appointment.CreatedBy = _loginUser.UserName;
                appointment.LastUpdateBy = _loginUser.UserName;

                if (DataHandler.IsAppointmentOverlapping(appointment.Start, appointment.End))
                {
                    MessageBox.Show("Error: Appointments can not overlap. ");
                    return;
                }
                if (appointment.End < appointment.Start)
                {
                    MessageBox.Show("Error: end date must be after start date. ");
                    return;
                }
                if (appointment.Start.DayOfWeek == DayOfWeek.Sunday || appointment.Start.DayOfWeek == DayOfWeek.Sunday ||
                    appointment.End.DayOfWeek == DayOfWeek.Sunday || appointment.End.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("Error: Appointment must be between Mon-Fri 9:00am to 5:00pm EST");
                    return;
                }

                DateTime estStart = ConvertUtcToEST(appointment.Start);
                DateTime estEnd = ConvertUtcToEST(appointment.End);

                if (estStart.Hour < 9 || estStart.Hour >= 17 || estEnd.Hour < 9 || estEnd.Hour > 17)
                {
                    MessageBox.Show("Error: Appointment must be between Mon-Fri 9:00am to 5:00pm EST");
                    return;
                }

                if (appointment.Type.Length < 1 || appointment.Title.Length < 1)
                {
                    MessageBox.Show("Error: Please enter a Title and a Type.");
                    return;
                }

                DataHandler.AddAppointment(appointment);
                MessageBox.Show("Appointment Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void LoadCustomerComboBox()
        {
            try
            {
                DataTable customerData = DataHandler.GetAllCustomers();

                if (customerData != null && customerData.Rows.Count > 0)
                {
                    comboCustomer.DataSource = customerData;

                    comboCustomer.DisplayMember = "customerName";

                    comboCustomer.ValueMember = "customerId";
                }
                else
                {
                    MessageBox.Show("No customers found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }
        private DateTime ConvertLocalToUtc(DateTime localDateTime)
        {
            // Ensure that the local time has the DateTimeKind.Local
            localDateTime = DateTime.SpecifyKind(localDateTime, DateTimeKind.Local);

            return TimeZoneInfo.ConvertTimeToUtc(localDateTime, TimeZoneInfo.Local);
        }

        private DateTime ConvertUtcToEST(DateTime utcDateTime)
        {
            TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, estZone);
        }
    }
}
