using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Game> games = new List<Game>();
        List<Drink> drinks = new List<Drink>();
        List<Book> books = new List<Book>();

        List<IProduct> products = new List<IProduct>();

        public void add(IProduct product)
        {
            this.products.Add(product);
        }

       

        public int getTotal()
        {
            return products.Sum(x => x.Price);
        }

        public bool isInBasket(String name)
        {
            foreach (IProduct p in this.products)
            {
                if (p.Name.Equals(name))
                {
                    return true;
                }
            }

            

            return false;
        }
    }
}
