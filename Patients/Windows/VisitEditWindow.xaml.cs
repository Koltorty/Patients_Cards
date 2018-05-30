using System;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows;
using Patients.Models;
using Patients.Models.Enums;

namespace Patients.Windows
{
    /// <summary>
    /// Логика взаимодействия для VisitEditWindow.xaml
    /// </summary>
    public partial class VisitEditWindow : Window
    {
        private readonly Context _context;
        public int VisitId { get; set; }
        public VisitEditWindow()
        {
            InitializeComponent();
            _context = new Context();
            Closing += VisitEditWindow_Closing;
        }

        private void VisitEditWindow_Closing(object sender, CancelEventArgs e)
        {
            _context.Dispose();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VisitsWindow window = new VisitsWindow();
                var visit = _context.Visits.SingleOrDefault(v => v.Id == VisitId);
                if (visit != null)
                {
                    visit.VisitDate = visitDatePicker.DisplayDate;
                    visit.Diagnosis = diagnosisTextBox.Text;
                    visit.VisitType = (VisitType)Enum.Parse(typeof(VisitType), visitTypeComboBox.Text);
                }

                _context.Visits.AddOrUpdate(visit);
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
