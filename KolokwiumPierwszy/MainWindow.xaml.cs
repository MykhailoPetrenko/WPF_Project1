using KolokwiumPierwszy.DAL;
using KolokwiumPierwszy.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KolokwiumPierwszy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmploeeDbServise _service;
        private static ObservableCollection<EMP> ListaPrecownikuw;
        public MainWindow()
        {
            InitializeComponent();
            _service = new EmploeeDbServise();
            ListaPrecownikuw = new ObservableCollection<EMP>(_service.GetPracowniki());
            DataGridPracownik.ItemsSource = ListaPrecownikuw;
            ComboBoxDname.ItemsSource = _service.GetDname();
        }

        private void Button_PokazWszystkich(object sender, RoutedEventArgs e)
        {
            DataGridPracownik.ItemsSource = _service.GetPracowniki();
        }

        private void Button_Szukaj(object sender, RoutedEventArgs e)
        {
            if (Nazwisko.Text.Length < 100)
            {
                ListaPrecownikuw = new ObservableCollection<EMP>(_service.SzukajPoNazwisku(Nazwisko.Text));
                DataGridPracownik.ItemsSource = ListaPrecownikuw;
                Nazwisko.Clear();
                if (ListaPrecownikuw.Count() == 0)
                {
                    string error = "Niema pracownika o takim nazwisku";
                    string ception = "Warning";
                    MessageBoxButton warning = MessageBoxButton.OKCancel;
                    MessageBoxImage image = MessageBoxImage.Warning;
                    MessageBox.Show(error, ception, warning, image);
                }
            }
            else
            {
                string error = "Za dlugie nazwisko";
                string ception = "Warning";
                MessageBoxButton warning = MessageBoxButton.OKCancel;
                MessageBoxImage image = MessageBoxImage.Warning;
                MessageBox.Show(error, ception, warning, image);
            }

        }

        private void Button_Dodaj(object sender, RoutedEventArgs e)
        {
            ListaPrecownikuw = new ObservableCollection<EMP>(_service.GetPracowniki());
            DataGridPracownik.ItemsSource = ListaPrecownikuw;
            if (TextBoxEmp.Text.Length < 100 && TextBoxJob.Text.Length < 100 &&  !string.IsNullOrEmpty(TextBoxEmp.Text) && !string.IsNullOrEmpty(TextBoxJob.Text) && ComboBoxDname.Text != "Select dzial")
            {

                var newEmp = new EMP
                {
                    EMPNO = _service.GetLastEmpno(),
                    ENAME = TextBoxEmp.Text,
                    JOB = TextBoxJob.Text,
                    DEPTNO = _service.GetDname(ComboBoxDname.Text)
                };
                _service.AddPracownik(newEmp);
                ListaPrecownikuw.Add(newEmp);

                TextBoxEmp.Clear();
                TextBoxJob.Clear();
                ComboBoxDname.Text = "Select dzial";
            }
            else
            {
                TextBoxEmp.Clear();
                TextBoxJob.Clear();
                string error = "Nieprawidlowe dane";
                string ception = "Warning";
                MessageBoxButton warning = MessageBoxButton.OKCancel;
                MessageBoxImage image = MessageBoxImage.Warning;
                MessageBox.Show(error, ception, warning, image);
            }
        }

        private void Button_Delet(object sender, RoutedEventArgs e)
        {
            var _Emploee = DataGridPracownik.SelectedItem;
            _service.deleteAnimal((EMP)_Emploee);
            ListaPrecownikuw.Remove((EMP)_Emploee);
        }
    }
}