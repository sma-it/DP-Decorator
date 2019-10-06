using System;

namespace StarbuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IResource order = null;

            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Pick a Drink", () =>
            {
                order = null;
                var drinksMenu = new SMUtils.Menu();
                drinksMenu.AddOption('1', "House Blend", () => order = new HouseBlend());
                drinksMenu.AddOption('2', "Dark Roast", () => order = new DarkRoast());
                drinksMenu.AddOption('3', "Espresso", () => order = new Espresso());
                drinksMenu.AddOption('4', "Decaf", () => order = new Decaf());
                drinksMenu.Start(true);
            });

            menu.AddOption('2', "Add Condiments", () =>
            {
                var condMenu = new SMUtils.Menu();
                condMenu.AddOption('1', "Add Soy", () =>
                {
                    order = new Soy(order);
                });
                condMenu.AddOption('2', "Add Milk", () =>
                {
                    order = new Milk(order);
                });
                condMenu.AddOption('3', "Add Mocha", () =>
                {
                    order = new Mocha(order);
                });
                condMenu.AddOption('4', "Add Cream", () =>
                {
                    order = new Cream(order);
                });
                condMenu.Start();
            });

            menu.AddOption('3', "Print Receipt", () =>
            {
                if(order == null)
                {
                    Console.WriteLine("You did not order anything");
                } else
                {
                    order.PrintReceipt();
                    Console.WriteLine("Total:\t\t" + order.Cost());
                }
            });

            menu.Start();
        }
    }
}
