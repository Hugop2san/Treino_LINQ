using System;
using System.Linq;
using System.Collections.Generic;
using treinolinq;

namespace treinolinq
{

    public class Program
    {
        public static void Main(string[] args)
        {

            static void Print<T>(string message, IEnumerable<T> collection)
            {
                Console.WriteLine(message); 

                foreach(T i in collection)
                {
                    Console.WriteLine(i);
                }
                
            }

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            
            List<Product> product = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Cat = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Cat = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Cat = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Cat = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Cat = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Cat = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Cat = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Cat = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Cat = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Cat = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Cat = c1 }
            };

            
            var r1 = product.Where(p => p.Cat.Tier==1 && p.Price > 900.00); // where é um filtro que espera logica booleana
            var r2 = product.Where(p => p.Cat.Name =="Tools").Select( p => (p.Name, p.Price));

            string message= "r1 > Tier 1 and Price > 900.00";
            Print(message, r1);

            string message2= "r2 > Category name Tools and prices";

            Print(message2, r2);

            
            
        }
    }
}