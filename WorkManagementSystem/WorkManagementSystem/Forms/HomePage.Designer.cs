namespace WorkManagementSystem.Forms
{
    partial class HomePage
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
            customerGridView = new DataGridView();
            btnAddCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            label1 = new Label();
            appointmentGridView = new DataGridView();
            label2 = new Label();
            btnAddAppointment = new Button();
            btnUpdateAppointment = new Button();
            btnDeleteAppointment = new Button();
            monthCalendar1 = new MonthCalendar();
            btnResetCalender = new Button();
            btnSelectDate = new Button();
            btnReports = new Button();
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appointmentGridView).BeginInit();
            SuspendLayout();
            // 
            // customerGridView
            // 
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerGridView.Location = new Point(12, 66);
            customerGridView.Name = "customerGridView";
            customerGridView.Size = new Size(642, 283);
            customerGridView.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Segoe UI", 11F);
            btnAddCustomer.Location = new Point(151, 374);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(87, 36);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Font = new Font("Segoe UI", 11F);
            btnUpdateCustomer.Location = new Point(269, 374);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(87, 36);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Font = new Font("Segoe UI", 11F);
            btnDeleteCustomer.Location = new Point(385, 374);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(87, 36);
            btnDeleteCustomer.TabIndex = 3;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(269, 22);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 4;
            label1.Text = "Customers";
            // 
            // appointmentGridView
            // 
            appointmentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentGridView.Location = new Point(780, 66);
            appointmentGridView.Name = "appointmentGridView";
            appointmentGridView.Size = new Size(642, 283);
            appointmentGridView.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(1011, 22);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 6;
            label2.Text = "Appointment Calender";
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Font = new Font("Segoe UI", 11F);
            btnAddAppointment.Location = new Point(942, 374);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(87, 36);
            btnAddAppointment.TabIndex = 7;
            btnAddAppointment.Text = "Add";
            btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.Font = new Font("Segoe UI", 11F);
            btnUpdateAppointment.Location = new Point(1072, 374);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new Size(87, 36);
            btnUpdateAppointment.TabIndex = 8;
            btnUpdateAppointment.Text = "Update";
            btnUpdateAppointment.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Font = new Font("Segoe UI", 11F);
            btnDeleteAppointment.Location = new Point(1199, 374);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(87, 36);
            btnDeleteAppointment.TabIndex = 9;
            btnDeleteAppointment.Text = "Delete";
            btnDeleteAppointment.UseVisualStyleBackColor = true;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(995, 445);
            monthCalendar1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MinDate = new DateTime(2001, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.Visible = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btnResetCalender
            // 
            btnResetCalender.Font = new Font("Segoe UI", 11F);
            btnResetCalender.Location = new Point(825, 432);
            btnResetCalender.Name = "btnResetCalender";
            btnResetCalender.Size = new Size(87, 36);
            btnResetCalender.TabIndex = 11;
            btnResetCalender.Text = "Reset";
            btnResetCalender.UseVisualStyleBackColor = true;
            btnResetCalender.Click += btnResetCalender_Click;
            // 
            // btnSelectDate
            // 
            btnSelectDate.Font = new Font("Segoe UI", 11F);
            btnSelectDate.Location = new Point(825, 374);
            btnSelectDate.Name = "btnSelectDate";
            btnSelectDate.Size = new Size(87, 52);
            btnSelectDate.TabIndex = 12;
            btnSelectDate.Text = "Select Date";
            btnSelectDate.UseVisualStyleBackColor = true;
            btnSelectDate.Click += btnSelectDate_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 15F);
            btnReports.Location = new Point(544, 555);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(344, 49);
            btnReports.TabIndex = 13;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 616);
            Controls.Add(btnReports);
            Controls.Add(btnSelectDate);
            Controls.Add(btnResetCalender);
            Controls.Add(monthCalendar1);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnUpdateAppointment);
            Controls.Add(btnAddAppointment);
            Controls.Add(label2);
            Controls.Add(appointmentGridView);
            Controls.Add(label1);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(customerGridView);
            Name = "HomePage";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)appointmentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView customerGridView;
        private Button btnAddCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private Label label1;
        private DataGridView appointmentGridView;
        private Label label2;
        private Button btnAddAppointment;
        private Button btnUpdateAppointment;
        private Button btnDeleteAppointment;
        private MonthCalendar monthCalendar1;
        private Button btnResetCalender;
        private Button btnSelectDate;
        private Button btnReports;
    }
}