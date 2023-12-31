﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    public class Indhold : INotifyPropertyChanged
    {
        public int ID { get; set; }
        private string _navn;
        public decimal _pris;
        public string Navn
        {
            get
            {
                return _navn;
            }
            set
            {
                _navn = value;
                OnPropertyChanged("Navn");
            }
    }

        public decimal Pris
        {
            get
            {
                return _pris;
            }
            set
            {
                _pris = value;
                OnPropertyChanged("Pris");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string PropertyNavn)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyNavn));
            }
        }
    }
}
