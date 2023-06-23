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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Customize.xaml
    /// </summary>
    public partial class Customize : Window, INotifyPropertyChanged
    {
        public decimal total { get; set; }
        public ObservableCollection<CartItem> CheckOutList { get; set; }

        public ObservableCollection<Toppings> toppings { get; set; }
        public ObservableCollection<Pizza> pizza { get; set; }

        public ObservableCollection<CartItem> _customize = new ObservableCollection<CartItem>();

        public int SelectedItemID;

        public ObservableCollection<CartItem> customize
        {
            get
            {
                return _customize;
            }
            set
            {
                _customize = value;
                OnPropertyChanged("customize");
            }
        }


        public Customize(decimal total, ObservableCollection<CartItem> CheckOutList, ObservableCollection<Toppings> toppings, ObservableCollection<Pizza> pizza)
        {
            this.total = total;
            this.CheckOutList = CheckOutList;
            this.toppings = toppings;
            this.pizza = pizza;
            DataContext = this;
            InitializeComponent();
        }

        private void tilføjBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Customize_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Topping_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CartItem_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string PropertyNavn)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyNavn));
            }
        }

        private void fortrydBtn_Click(object sender, RoutedEventArgs e)
        {
            customize.Clear();
        }

        private void Bekræft_Btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
