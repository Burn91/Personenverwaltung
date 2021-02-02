using System;
using System.Collections.Generic;
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
using System.IO;
using System.Globalization;


namespace Personenverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonViewModel ViewModel { get; set; }
        public MainWindow()
        {
            this.ViewModel = new PersonViewModel();
            InitializeComponent();
            this.DataContext = this.ViewModel;
        }

        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void DataGridComboBoxColumn_SettingData(object sender, DataObjectSettingDataEventArgs e)
        {

        }
    }
    }
