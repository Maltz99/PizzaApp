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
        private readonly DAL dal;

        private decimal total = 0;
        
        public MainWindow()
        {
            InitializeComponent();


            dal = new DAL
            {
                CheckOutList = new ObservableCollection<CartItem>()
            };

            DataContext = dal;
            Opdater_Total();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckOut checkOut = new CheckOut(total, dal.CheckOutList);
         
            checkOut.ShowDialog();

            if (checkOut.DialogResult == true )
            {

                dal.CheckOutList.Clear();
                //Tøm chechkout listen
            }
            Opdater_Total();
        }

        private void CustomizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Customize custom = new Customize(total, dal.CheckOutList, dal.toppings, dal.pizza);
            custom.ShowDialog();
        }

        private void Pizza_Click(object sender, RoutedEventArgs e)
        {
            Button? b = sender as Button;
            if (b != null)
            {
                Pizza? p = b.DataContext as Pizza;
                if (p != null)
                {
                    CartItem cartItem = new CartItem(p);
                    dal.CheckOutList.Add(cartItem);
                }
            }
            Opdater_Total();
        }

        private void Tilbehør_Click(Object sender, RoutedEventArgs e)
        {
            Button? b = sender as Button;
            if (b != null)
            {
                Tilbehør? t = b.DataContext as Tilbehør;
                if (t != null)
                {
                    CartItem cartItem = new CartItem(t);
                    dal.CheckOutList.Add(cartItem);
                }
            }
            Opdater_Total();
        }

        private void CheckOut_Click(object sender, RoutedEventArgs e)
        {
            Button? b = sender as Button;
            if (b != null)
            {
                CartItem? c = b.DataContext as CartItem;
                dal.CheckOutList.Remove(c);
            }
            Opdater_Total();
        }

        private void Opdater_Total()
        {
            total = 0;
            foreach (CartItem cartItem in dal.CheckOutList)
            
                total += cartItem.Pris;
            
            prisTb.Text = total.ToString();
        }
    }

}
