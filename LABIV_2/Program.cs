using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LABIV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();
            ctx.Database.EnsureCreated();
            ctx.Zajecias.Add(new Zajecia() { Nazwa = "p4", IloscObecnych= 15 ,Sala="B316" });
            ctx.SaveChanges();
            /*
            foreach (var item in ctx.Zajecias)
            {
                Console.WriteLine(item.Nazwa);
            }
            */

            /*
            using var znorthwindContext = new ZNorthwindContext();

            var ukKlienci = znorthwindContex.Customers.Where(x => x.Country == "UK");
            foreach (var item in ukKlienci)
            {
                Console.WriteLine(Klienci.Zamówienia);
                foreach (var item in )
                {
                 

                }
            }
            */
        }
    }
}
