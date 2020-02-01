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

namespace Lijsten.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstWeekdagen.Items.Add("maandag");
            lstWeekdagen.Items.Add("dinsdag");
            lstWeekdagen.Items.Add("woensdag");
            lstWeekdagen.Items.Add("donderdag");
            lstWeekdagen.Items.Add("vrijdag");
            lstWeekdagen.Items.Add("zaterdag");
            lstWeekdagen.Items.Add("zondag");

            cmbWeekdagNummer.Items.Add(1);
            cmbWeekdagNummer.Items.Add(2);
            cmbWeekdagNummer.Items.Add(3);
            cmbWeekdagNummer.Items.Add(4);
            cmbWeekdagNummer.Items.Add(5);
            cmbWeekdagNummer.Items.Add(6);
            cmbWeekdagNummer.Items.Add(7);


        }

        private void lstWeekdagen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Title = "Je koos voor " + lstWeekdagen.SelectedItem.ToString();

        }

        private void cmbWeekdagNummer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(cmbWeekdagNummer.SelectedItem);
            lstWeekdagen.SelectedIndex = (int)cmbWeekdagNummer.SelectedItem -1;
        }
    }
}
