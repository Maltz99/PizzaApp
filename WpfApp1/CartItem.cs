using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
     public class CartItem : Indhold
    {
        public CartItem(Tilbehør T) {
            ID = T.ID;
            Navn = T.Navn;
            Pris = T.Pris;
        }

        public CartItem(Pizza P)
        {
            ID = P.ID;
            Navn = P.Navn;
            Pris = P.Pris;
        }

        public CartItem(CartItem T)
        {
            ID = T.ID;
            Navn = T.Navn;
            Pris = T.Pris;
        }

        public CartItem(Toppings T)
        {
            ID = T.ID;
            Navn = T.Navn;
            Pris = T.Pris;
        }
    }
}
