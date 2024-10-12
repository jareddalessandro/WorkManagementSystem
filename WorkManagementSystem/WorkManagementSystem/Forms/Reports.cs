using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkManagementSystem.Utils;

namespace WorkManagementSystem.Forms
{
    public partial class Reports : Form
    {
        DataHandler DataHandler = new DataHandler();
        public Reports()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateAppointmentTypesByMonthReport()
        {
            var appointments = DataHandler.GetAppointments();  

            var report = appointments
                .GroupBy(a => new { Month = a.Start.Month, Type = a.Type })  
                .Select(g => new
                {
                    Month = g.Key.Month,
                    Type = g.Key.Type,
                    Count = g.Count()  
                })
                .OrderBy(r => r.Month)  
                .ThenBy(r => r.Type)    
                .ToList();

            foreach (var entry in report)
            {
                MessageBox.Show($"Month: {entry.Month}, Type: {entry.Type}, Count: {entry.Count}");
            }
        }

        private void GenerateScheduleForEachUserReport()
        {
            var appointments = DataHandler.GetAppointments();  

            var report = appointments
                .GroupBy(a => a.UserId)  
                .Select(g => new
                {
                    UserId = g.Key,
                    Appointments = g.Select(a => new
                    {
                        a.Title,
                        a.Start,
                        a.End
                    }).ToList()
                })
                .ToList();

            foreach (var userSchedule in report)
            {
                MessageBox.Show($"User ID: {userSchedule.UserId}");
                foreach (var appt in userSchedule.Appointments)
                {
                    MessageBox.Show($"Title: {appt.Title}, Start: {ConvertUtcToLocal(appt.Start)}, End: {ConvertUtcToLocal(appt.End)}");
                }
            }
        }

        private void GenerateTotalAppointmentsByCustomerReport()
        {
            var appointments = DataHandler.GetAppointments();  

            var report = appointments
                .GroupBy(a => a.CustomerId)  
                .Select(g => new
                {
                    CustomerId = g.Key,
                    Count = g.Count() 
                })
                .ToList();


            foreach (var entry in report)
            {
                MessageBox.Show($"Customer ID: {entry.CustomerId}, Total Appointments: {entry.Count}");
            }
        }

        private void btnReportApptTypes_Click(object sender, EventArgs e)
        {
            GenerateAppointmentTypesByMonthReport();
        }

        private void btnReportSchedule_Click(object sender, EventArgs e)
        {
            GenerateScheduleForEachUserReport();
        }

        private void btnAppointmentCustomer_Click(object sender, EventArgs e)
        {
            GenerateTotalAppointmentsByCustomerReport();
        }

        private DateTime ConvertUtcToLocal(DateTime utcDateTime)
        {
            // Ensure that the UTC time has the DateTimeKind.Utc
            utcDateTime = DateTime.SpecifyKind(utcDateTime, DateTimeKind.Utc);

            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, TimeZoneInfo.Local);
        }
    }
}
