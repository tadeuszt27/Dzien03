using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    enum OrderStatus
    {
        NewOrder = 10,
        Complete = 20,
        Confirmed = 30,
        Shipped = 40,
        Returned = 50,
        Cancelled = 60
    }
    class Order     // to jest zamówienie - kto zamawia, jak realizuje platnosc itp.
    {
        private String orderNumber;
        private String customerName;
        private String shipAddress;
        private DateTime orderDate;
        private OrderStatus status = OrderStatus.NewOrder;
        private byte discount = 0;           // zniżka procentowa
        private List<OrderItem> items = new List<OrderItem>();  // lista obiektów klasy OrderItem - kolekcja

        /// <summary>
        /// usuwa wszystkie elementy z zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Clear()
        {
            if (status == OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetProductIndex(Product product)   // tylko wewnetrznie dzialajaca metoda na obiekcie
        {
            int result = -1;                       // -1 jeßli  nie znalazla a jeßli 0 lub wiécej bédzie wskazywaøa pozycje
            for (int i = 0; i < items.Count; i++)  // odwolanie do propercji Count, æeby okreslic ile mamy elementów w naszej kolekcji
            {
                if (items[i].Produkt.Name.Equals(product.Name))  // siegniecie do obiektu po nazwe za pomoca propercji
                {                                                
                    return i;
                }
            }
            return result;
        }

        /// <summary>
        /// Dodaje produkt do listy w zamówieniu
        /// </summary>
        /// <param name="product"></param>
        /// <param name="qnty"></param>
        /// <returns></returns>
        public bool AddProduct(Product product, int qnty)
        {
            if (product != null && qnty > 0 && status == OrderStatus.NewOrder)
            {
                //int productIndex = GetProductIndex(product);
                int productIndex = items.FindIndex(x => x.Produkt.Name.Equals(product.Name));
                if (productIndex == -1)
                {
                    items.Add(new OrderItem(product, qnty));
                }
                else
                {
                    items[productIndex].Qnty += qnty;   // zwiekszenie qnty jest moæliwe przez utworzenie set w propercji Qnty 
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Usuwa produkt z listy zamówienia
        /// </summary>
        /// <param name="product"></param>
        /// <param name="qnty"></param>
        /// <returns></returns>
        public bool RemoveProduct(Product product, int qnty = 0)  // qnty ma wartosc domyslna wiec mozna wpisac jeden parametr
        {
            if (product != null && qnty >= 0 && status == OrderStatus.NewOrder)
            {
                //int productIndex = GetProductIndex(product);
                int productIndex = items.FindIndex(x => x.Produkt.Name.Equals(product.Name));
                if (productIndex == -1) return false;
                if (qnty > items[productIndex].Qnty) return false;  // jesli chcemy usunac wiecej elementow niz mamy w koszyku to nierob nic

                if (qnty == 0 || qnty == items[productIndex].Qnty)  // usówamy caly produkt z naszej kolekcji - gdy ilosc jest taka sama lub równa 0
                {
                    items.RemoveAt(productIndex);     // metoda usowa i-ty produkt w naszej kolekcji
                    return true;
                }
                items[productIndex].Qnty -= qnty;

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Wartość zamówienia
        /// </summary>
        /// <returns></returns>
        public double CalcTotalAmount()
        {
            double amount = 0.0;
            items.ForEach(e => amount += e.Produkt.Price * e.Qnty);
            //foreach (var item in items)
            //{
            //    amount += item.Qnty * item.Product.Price;
            //}
            if (discount > 0 && discount <= 100)
            {
                amount *= (100 - discount) / 100.0;  // Uwaga !! Nie moze byc dzielenia przez calkowite 100 bo nie bedzie konwersji zmiennoprzecinkowe
            }
            return amount;
        }

        /// <summary>
        /// wypisuje na konsoli pozycje zamówienia
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Elementy zamówienia");
            //foreach (var item in items)               // nie potrzebuje indeksow z naszej kolekcji wiec wystarczy foreach 
            //{
            //    Console.WriteLine("{0,-40}|{1,10}|{2,10:0.00}|{3,12:0.00}",
            //        item.Product.Name, item.Qnty, item.Product.Price,       // trzeba dodacw klasie Produkt propercje Price
            //        item.Qnty * item.Product.Price);
            //}
            items.ForEach(item => Console.WriteLine("{0,-40}|{1,10}|{2,10:0.00}|{3,12:0.00}",
                    item.Produkt.Name, item.Qnty, item.Produkt.Price,
                    item.Qnty * item.Produkt.Price));
            Console.WriteLine("Do zapłaty: {0:0.00}", CalcTotalAmount());
        }

    }
}

