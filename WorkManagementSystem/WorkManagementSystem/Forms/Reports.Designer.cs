namespace WorkManagementSystem.Forms
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            btnReportApptTypes = new Button();
            btnReportSchedule = new Button();
            btnAppointmentCustomer = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(255, 399);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 39);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnReportApptTypes
            // 
            btnReportApptTypes.Font = new Font("Segoe UI", 12F);
            btnReportApptTypes.Location = new Point(170, 124);
            btnReportApptTypes.Name = "btnReportApptTypes";
            btnReportApptTypes.Size = new Size(295, 37);
            btnReportApptTypes.TabIndex = 2;
            btnReportApptTypes.Text = "Appointment Types by Month";
            btnReportApptTypes.UseVisualStyleBackColor = true;
            btnReportApptTypes.Click += btnReportApptTypes_Click;
            // 
            // btnReportSchedule
            // 
            btnReportSchedule.Font = new Font("Segoe UI", 12F);
            btnReportSchedule.Location = new Point(170, 181);
            btnReportSchedule.Name = "btnReportSchedule";
            btnReportSchedule.Size = new Size(295, 37);
            btnReportSchedule.TabIndex = 3;
            btnReportSchedule.Text = "Schedule for Each User";
            btnReportSchedule.UseVisualStyleBackColor = true;
            btnReportSchedule.Click += btnReportSchedule_Click;
            // 
            // btnAppointmentCustomer
            // 
            btnAppointmentCustomer.Font = new Font("Segoe UI", 12F);
            btnAppointmentCustomer.Location = new Point(170, 238);
            btnAppointmentCustomer.Name = "btnAppointmentCustomer";
            btnAppointmentCustomer.Size = new Size(295, 37);
            btnAppointmentCustomer.TabIndex = 4;
            btnAppointmentCustomer.Text = "Appointments by Customer";
            btnAppointmentCustomer.UseVisualStyleBackColor = true;
            btnAppointmentCustomer.Click += btnAppointmentCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(268, 31);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 5;
            label1.Text = "Reports";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            Controls.Add(label1);
            Controls.Add(btnAppointmentCustomer);
            Controls.Add(btnReportSchedule);
            Controls.Add(btnReportApptTypes);
            Controls.Add(btnClose);
            Name = "Reports";
            Text = "Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnReportApptTypes;
        private Button btnReportSchedule;
        private Button btnAppointmentCustomer;
        private Label label1;
    }
}