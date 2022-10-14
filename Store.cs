using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Store
    {
        public static void Start()
        {
            // Opret 3 pizzaobjekter
            Pizza pizza1 = new Pizza("Margherita", 55);
            Pizza pizza2 = new Pizza("Calzone", 64);
            Pizza pizza3 = new Pizza("Vesuvio", 56);

            // Opret 3 kundeobjekter
            Kunde customer1 = new Kunde("Andreas", "Dragsberg");
            Kunde customer2 = new Kunde("Mikkel", "Christiansen");
            Kunde customer3 = new Kunde("Tristan", "Stenalt");

            // Opret 3 ordreobjekter
            Ordre order1 = new Ordre(pizza1, customer1);
            Ordre order2 = new Ordre(pizza2, customer2);
            Ordre order3 = new Ordre(pizza3, customer3);

            // Udskriv ordreinformationer
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);

            // Test CalculateTotalPrice metoden

        }

    }
}
