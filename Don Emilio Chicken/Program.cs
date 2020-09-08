using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_Emilio_Chicken
{
    class Program
    {
        List<Combo<int>> createCombos()
        {
            var combosList = new List<Combo<int>>();
            var combo1 = new Combo<int>()
            {
                ID = 1,
                chicken = new Pollito(),
                drink=new Coke()
            };
            var combo2 = new Combo<int>()
            {
                ID = 2,
                chicken = new PolloNormal(),
                drink = new Juice()
            };
            var combo3 = new Combo<int>()
            {
                ID = 3,
                chicken = new PollexPremium(),
                drink = new Limonada()
            };
            combosList.Add(combo1);
            combosList.Add(combo2);
            combosList.Add(combo3);
            return combosList;
        }
        void ComboMenu(List<Combo<int>> comboList)
        {
            Console.WriteLine("MENU\n");
            foreach(var item in comboList)
            {
                Console.WriteLine($"Combo {item.ID}");
                Console.WriteLine($"Pollo: {item.chicken.getName()}");
                Console.WriteLine($"Drink: {item.drink.getName()}");
            }
        }
        void chooseCombo(List<Combo<int>>combos)
        {
            var cashier = new Cashier();
            var chef = new Chef<int>();
            Console.WriteLine("Nombre del Cliente:");
            cashier.setClient(Console.ReadLine());
            Console.WriteLine("Combo:");
            cashier.setCombo(Convert.ToInt32(Console.ReadLine()));
            var chicken=chef.PrepareChickenAsync()

        }
        async void menu()
        {
            var combos = createCombos();
            string opcion = "0";
            do
            {
                Console.WriteLine("Pollos Don Emilio");
                Console.WriteLine("\n1.Visualizar Menu\n2.Elegir Combo\n3.Limpiar Mesa\n4.Borrar Pantalla");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        ComboMenu(combos);
                        break;
                    case "2":
                        

                }
            }
            while (opcion != "0");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
