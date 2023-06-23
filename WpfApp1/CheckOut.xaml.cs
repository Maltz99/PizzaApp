using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class CheckOut : Window
    {
        public decimal total { get; set; }
        public ObservableCollection<CartItem> CheckOutList { get; set; }


        public CheckOut(decimal total, ObservableCollection<CartItem> CheckOutList)
        {
            this.total = total;
            this.CheckOutList = CheckOutList;
            DataContext = this;
            InitializeComponent();

            prisTb.Text = total.ToString();
        }

        private void btn_fortryd_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void btn_betal_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
