using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private DAL dal;
        



        public MainWindow()
        {
            InitializeComponent();

          
            dal = new DAL();
            dal.CheckOutList = new ObservableCollection<CartItem>();
           
            DataContext = dal;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.ShowDialog();

            if (checkOut.DialogResult == true )
            {

                dal.CheckOutList.Clear();
                //Tøm chechkout listen
            }
        }

        private void Pizza_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                Pizza p = b.DataContext as Pizza;
                Debug.WriteLine($"Du har valgt {p.Navn}");   
               
            }

        }

        private void Tilbehør_Click(Object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                Tilbehør t = b.DataContext as Tilbehør;
                Debug.WriteLine($"Du har valgt {t.Navn}");
            }
        }

        private void CheckOut_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {

            }
        }
    }

}
