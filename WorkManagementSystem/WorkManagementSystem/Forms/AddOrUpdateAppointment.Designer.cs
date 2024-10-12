namespace WorkManagementSystem.Forms
{
    partial class AddOrUpdateAppointment
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSaveAppointment = new Button();
            btnClose = new Button();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtType = new TextBox();
            txtLocation = new TextBox();
            txtContact = new TextBox();
            comboCustomer = new ComboBox();
            label10 = new Label();
            txtUrl = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 22);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 1;
            label2.Text = "Start Date/Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(18, 113);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "End Date/Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(89, 150);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 3;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(42, 184);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(87, 217);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 5;
            label6.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(61, 253);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 6;
            label7.Text = "Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(67, 286);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 7;
            label8.Text = "Contact";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(55, 358);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 8;
            label9.Text = "Customer";
            // 
            // btnSaveAppointment
            // 
            btnSaveAppointment.Location = new Point(216, 396);
            btnSaveAppointment.Name = "btnSaveAppointment";
            btnSaveAppointment.Size = new Size(75, 23);
            btnSaveAppointment.TabIndex = 9;
            btnSaveAppointment.Text = "Save";
            btnSaveAppointment.UseVisualStyleBackColor = true;
            btnSaveAppointment.Click += btnSaveAppointment_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(297, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // startDatePicker
            // 
            startDatePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(133, 78);
            startDatePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            startDatePicker.MinDate = new DateTime(2001, 1, 1, 0, 0, 0, 0);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(161, 23);
            startDatePicker.TabIndex = 11;
            startDatePicker.Value = new DateTime(2024, 10, 20, 15, 42, 0, 0);
            // 
            // endDatePicker
            // 
            endDatePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.Location = new Point(133, 111);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(161, 23);
            endDatePicker.TabIndex = 12;
            endDatePicker.Value = new DateTime(2024, 10, 20, 15, 42, 0, 0);
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(133, 147);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(239, 23);
            txtTitle.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(133, 184);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(239, 23);
            txtDescription.TabIndex = 14;
            // 
            // txtType
            // 
            txtType.Location = new Point(133, 218);
            txtType.Name = "txtType";
            txtType.Size = new Size(239, 23);
            txtType.TabIndex = 15;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(133, 253);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(239, 23);
            txtLocation.TabIndex = 16;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(133, 287);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(239, 23);
            txtContact.TabIndex = 17;
            // 
            // comboCustomer
            // 
            comboCustomer.FormattingEnabled = true;
            comboCustomer.Location = new Point(133, 355);
            comboCustomer.Name = "comboCustomer";
            comboCustomer.Size = new Size(239, 23);
            comboCustomer.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(92, 325);
            label10.Name = "label10";
            label10.Size = new Size(35, 20);
            label10.TabIndex = 19;
            label10.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(133, 322);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(239, 23);
            txtUrl.TabIndex = 20;
            // 
            // AddOrUpdateAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 431);
            Controls.Add(txtUrl);
            Controls.Add(label10);
            Controls.Add(comboCustomer);
            Controls.Add(txtContact);
            Controls.Add(txtLocation);
            Controls.Add(txtType);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(btnClose);
            Controls.Add(btnSaveAppointment);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddOrUpdateAppointment";
            Text = "AddOrUpdateAppointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSaveAppointment;
        private Button btnClose;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtType;
        private TextBox txtLocation;
        private TextBox txtContact;
        private ComboBox comboCustomer;
        private Label label10;
        private TextBox txtUrl;
    }
}