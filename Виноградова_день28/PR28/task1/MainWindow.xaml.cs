using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace ParkingLot
{
    public partial class MainWindow : Window
    {
        private XDocument parkingXml;

        public MainWindow()
        {
            InitializeComponent();
            //carsTextBox1.Visibility = Visibility.Collapsed;
        }


        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(brandTextBox.Text) || string.IsNullOrWhiteSpace(yearTextBox.Text) || string.IsNullOrWhiteSpace(rentPeriodTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (parkingXml == null)
            {
                parkingXml = new XDocument(new XElement("Автостоянка"));
            }

            parkingXml.Root.Add(new XElement("Автомобиль",
                new XElement("Марка", brandTextBox.Text),
                new XElement("ГодВыпуска", yearTextBox.Text),
                new XElement("СрокАренды", rentPeriodTextBox.Text)));

            carsListBox.Items.Add(brandTextBox.Text);

            brandTextBox.Clear();
            yearTextBox.Clear();
            rentPeriodTextBox.Clear();
        }

        private void LoadXml_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                parkingXml = XDocument.Load(openFileDialog.FileName);
                carsListBox.Items.Clear();
                foreach (XElement car in parkingXml.Root.Elements("Автомобиль"))
                {
                    carsListBox.Items.Add(car.Element("Марка").Value);
                }
            }
        }

        private void SaveXml_Click(object sender, RoutedEventArgs e)
        {
            if (parkingXml != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == true)
                {
                    parkingXml.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения.");
            }
        }

        private void SearchCar_Click(object sender, RoutedEventArgs e)
        {
            string searchBrand = searchTextBox.Text;
            var car = parkingXml.Root.Elements("Автомобиль").FirstOrDefault(x => x.Element("Марка").Value == searchBrand);
            if (car != null)
            {
                MessageBox.Show($"Автомобиль найден: {car.Element("Марка").Value}, {car.Element("ГодВыпуска").Value}, аренда на {car.Element("СрокАренды").Value} дней");
            }
            else
            {
                MessageBox.Show("Автомобиль не найден.");
            }
        }

        private void DeleteCar_Click(object sender, RoutedEventArgs e)
        {
            string deleteBrand = deleteTextBox.Text;
            var car = parkingXml.Root.Elements("Автомобиль").FirstOrDefault(x => x.Element("Марка").Value == deleteBrand);
            if (car != null)
            {
                car.Remove();
                carsListBox.Items.Remove(deleteBrand);
                MessageBox.Show("Автомобиль удален.");
            }
            else
            {
                MessageBox.Show("Автомобиль не найден.");
            }
        }

        private void DisplayInTextBox_Checked(object sender, RoutedEventArgs e)
        {
            carsTextBox1.Visibility = Visibility.Visible;
            carsTreeView.Visibility = Visibility.Collapsed;
            carsListBox1.Visibility = Visibility.Collapsed;

            carsTextBox1.Text = string.Join(Environment.NewLine, carsListBox.Items.Cast<string>());
        }

        private void DisplayInTreeView_Checked(object sender, RoutedEventArgs e)
        {
            carsTextBox1.Visibility = Visibility.Collapsed;
            carsTreeView.Visibility = Visibility.Visible;
            carsListBox1.Visibility = Visibility.Collapsed;

            carsTreeView.Items.Clear();
            foreach (var item in carsListBox.Items)
            {
                carsTreeView.Items.Add(new TreeViewItem { Header = item });
            }
        }

        private void DisplayInListBox_Checked(object sender, RoutedEventArgs e)
        {
            carsTextBox1.Visibility = Visibility.Collapsed;
            carsTreeView.Visibility = Visibility.Collapsed;
            carsListBox1.Visibility = Visibility.Visible;

            carsListBox1.Items.Clear();
            foreach (var item in carsListBox.Items)
            {
                carsListBox1.Items.Add(item);
            }
        }
    }
}
