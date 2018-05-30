using System;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows;
using Patients.Models;

namespace Patients
{
    /// <summary>
    /// Логика взаимодействия для PatientEditWindow.xaml
    /// </summary>
    public partial class PatientEditWindow : Window
    {
        private readonly Context _context;
        public int PatientId { get; set; }
        public PatientEditWindow()
        {
            InitializeComponent();
            _context = new Context();
            Closing += PatientEditWindow_Closing;
        }

        private void PatientEditWindow_Closing(object sender, CancelEventArgs e)
        {
            _context.Dispose();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var patient = _context.Patients.SingleOrDefault(p => p.Id == PatientId);
                if (patient != null)
                {
                    patient.FirstName = firstNameTextBox.Text;
                    patient.LastName = lastNameTextBox.Text;
                    patient.BirthDate = birthDatePicker.DisplayDate;
                    patient.Gender = (Genders)Enum.Parse(typeof(Genders), genderComboBox.Text);
                    patient.Address = addressTextBox.Text;
                    patient.Phone = phoneTextBox.Text;
                }

                _context.Patients.AddOrUpdate(patient);
                _context.SaveChanges();
                Close();
            }
            catch (Exception)
            {
                errorTextBlock.Text = "Input data is incorrect. Please, check your data and try again";
            }
        }
    }
}
