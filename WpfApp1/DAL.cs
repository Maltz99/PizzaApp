using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class DAL
    {
        public  ObservableCollection<Toppings> toppings { get; set; } = new ObservableCollection<Toppings>();
        public ObservableCollection<Pizza> pizza { get; set; } = new ObservableCollection<Pizza>();
        public ObservableCollection<Tilbehør> tilbehør { get; set; } = new ObservableCollection<Tilbehør>();

        public ObservableCollection<CartItem> CheckOutList { get; set; } = new ObservableCollection<CartItem>();



        public DAL()
        {
            

            //Tilføjer Pizzaer til list
            pizza.Add(new Pizza { ID = 1, Navn = "Margarita Pizza", Pris = 60 });
            pizza.Add(new Pizza { ID = 2, Navn = "Pepperoni Pizza", Pris = 75 });
            pizza.Add(new Pizza { ID = 3, Navn = "Kebab Pizza", Pris = 75 });
            pizza.Add(new Pizza { ID = 4, Navn = "Hawaii Pizza", Pris = 75 });
            pizza.Add(new Pizza { ID = 5, Navn = "Salat Pizza", Pris = 75 });
            pizza.Add(new Pizza { ID = 6, Navn = "Parmesan Pizza", Pris = 80 });
            pizza.Add(new Pizza { ID = 7, Navn = "Calzone", Pris = 85 });
            pizza.Add(new Pizza { ID = 8, Navn = "Husets Favorit", Pris = 90 });

            //Tilføjer toppings til list
            toppings.Add(new Toppings { ID = 9, Navn = "Ost", Pris = 10 });
            toppings.Add(new Toppings { ID = 10, Navn = "Pepperoni", Pris = 15 });
            toppings.Add(new Toppings { ID = 11, Navn = "Dressing", Pris = 5 });
            toppings.Add(new Toppings { ID = 12, Navn = "Kebab", Pris = 15 });
            toppings.Add(new Toppings { ID = 13, Navn = "Oliven", Pris = 5 });

            //Tilføjer tilbehør til list
            tilbehør.Add(new Tilbehør { ID = 14, Navn = "Pommes Frites", Pris = 35 });
            tilbehør.Add(new Tilbehør { ID = 15, Navn = "Coca Cola", Pris = 20 });
            tilbehør.Add(new Tilbehør { ID = 16, Navn = "Fanta", Pris = 20 });
            tilbehør.Add(new Tilbehør { ID = 17, Navn = "Sprite", Pris = 20 });
            tilbehør.Add(new Tilbehør { ID = 18, Navn = "Coca Cola Zero", Pris = 20 });
            tilbehør.Add(new Tilbehør { ID = 19, Navn = "Faxe Kondi", Pris = 20 });
        } 
    }
}
