using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using Patients.Models;

namespace Patients
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context _context;
        public MainWindow()
        {
            InitializeComponent();
            _context = new Context();
            _context.Patients.Load();
            patientsGrid.ItemsSource = _context.Patients.Local.ToBindingList();
            Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            _context.Dispose();
        }

        private void addNewPatientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Patient patient = new Patient()
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    BirthDate = birthDatePicker.DisplayDate,
                    Gender = (Genders)Enum.Parse(typeof(Genders), genderComboBox.Text),
                    Address = addressTextBox.Text,
                    Phone = phoneTextBox.Text
                };

                _context.Patients.Add(patient);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                errorTextBlock.Text = "Incorrect input data. Please, check your data and try again";
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (patientsGrid.SelectedItems.Count > 0)
            {
                for(int i = 0; i < patientsGrid.SelectedItems.Count; i++)
                {
                    Patient patient = patientsGrid.SelectedItems[i] as Patient;
                    if (patient != null)
                    {
                        _context.Patients.Remove(patient);
                    }
                }
            }
            _context.SaveChanges();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (patientsGrid.SelectedItems.Count != 1)
            {
                errorTextBlock.Text = "Please choose one patient to edit";
            }
            else
            {
                try
                {
                    Patient patient = patientsGrid.SelectedItems[0] as Patient;
                    PatientEditWindow editWindow = new PatientEditWindow();
                    if (patient != null)
                    {
                        editWindow.firstNameTextBox.Text = patient.FirstName;
                        editWindow.lastNameTextBox.Text = patient.LastName;
                        editWindow.birthDatePicker.DisplayDate = patient.BirthDate;
                        editWindow.addressTextBox.Text = patient.Address;
                        editWindow.genderComboBox.Text = patient.Gender.ToString();
                        editWindow.phoneTextBox.Text = patient.Phone;
                        editWindow.PatientId = patient.Id;
                    }
                    editWindow.Show();
                }
                catch (Exception)
                {
                    errorTextBlock.Text = "You didn't choose the patient";
                }
            }
        }

        private void visitsButton_Click(object sender, RoutedEventArgs e)
        {
            if (patientsGrid.SelectedItems.Count > 1)
            {
                errorTextBlock.Text = "Choose one patient to see their visits";
            }
            else
            {
                Patient patient = patientsGrid.SelectedItems[0] as Patient;
                var visits = _context.Visits.Where(v => v.PatientId == patient.Id);

                if (patient != null)
                {
                    VisitsWindow visitsWindow = new VisitsWindow
                    {
                        visitsGrid = {ItemsSource = visits.ToList()},
                        PatientId = patient.Id
                    };

                    visitsWindow.Show();
                }
            }
        }
    }
}
