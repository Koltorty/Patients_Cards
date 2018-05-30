using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using Patients.Models;
using Patients.Models.Enums;
using Patients.Windows;

namespace Patients
{
    /// <summary>
    /// Логика взаимодействия для VisitsWindow.xaml
    /// </summary>
    public partial class VisitsWindow : Window
    {
        private readonly Context _context;
        public int PatientId { get; set; }
        public VisitsWindow()
        {
            InitializeComponent();
            _context = new Context();
            _context.Visits.Load();
            visitsGrid.ItemsSource = _context.Visits.Where(v => v.PatientId == PatientId).ToList();

            Closing += VisitsWindow_Closing;
        }

        private void VisitsWindow_Closing(object sender, CancelEventArgs e)
        {
            _context.Dispose();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Visit visit = new Visit()
                {
                    Diagnosis = diagnosisTextBox.Text,
                    VisitDate = visitDatePicker.DisplayDate,
                    VisitType = (VisitType)Enum.Parse(typeof(VisitType), visitTypeComboBox.Text),
                    PatientId = PatientId
                };

                _context.Visits.Add(visit);
                _context.SaveChanges();

                visitsGrid.ItemsSource = _context.Visits.Where(v => v.PatientId == PatientId).ToList();
            }
            catch (Exception)
            {
                errorTextBlock.Text = "Incorrect input data. Please, check your data and try again";
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (visitsGrid.SelectedItems.Count > 0)
            {
                var visits = _context.Visits.ToList();
                for (int i = 0; i < visitsGrid.SelectedItems.Count; i++)
                {
                    var v1 = visitsGrid.SelectedItems[i] as Visit;
                    Visit visit = visits.SingleOrDefault(v => v.Id == v1?.Id);
                    if (visit != null)
                    {
                        _context.Visits.Remove(visit);
                    }
                }
            }
            _context.SaveChanges();
            visitsGrid.ItemsSource = _context.Visits.Where(v => v.PatientId == PatientId).ToList();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (visitsGrid.SelectedItems.Count != 1)
            {
                errorTextBlock.Text = "Please choose one visit to edit";
            }
            else
            {
                try
                {
                    Visit visit = visitsGrid.SelectedItems[0] as Visit;
                    VisitEditWindow editWindow = new VisitEditWindow();
                    if (visit != null)
                    {
                        editWindow.visitDatePicker.DisplayDate = visit.VisitDate;
                        editWindow.diagnosisTextBox.Text = visit.Diagnosis;
                        editWindow.visitTypeComboBox.Text = visit.VisitType.ToString();
                        editWindow.VisitId = visit.Id;
                    }
                    editWindow.Show();
                }
                catch (Exception)
                {
                    errorTextBlock.Text = "You didn't choose the visit";
                }
            }
        }
    }
}
