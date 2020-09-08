using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Don_Emilio_Chicken
{
    class Cashier<T>
    {
        public void cleanTable(int tablenumber)
        {
            Console.WriteLine($"Limpiando mesa #{tablenumber}");
            Thread.Sleep(1000);
            Console.WriteLine($"Mesa {tablenumber} limpia");
        }
        public Order takeOrder()
        {
            var order = new Order();
            Console.WriteLine("Nombre del Cliente:");
            order.setClient(Console.ReadLine());
            Console.WriteLine("Combo:");
            order.setCombo(Convert.ToInt32(Console.ReadLine()));
            return order;
        }
        public void ComboMenu(List<Combo<T>> comboList)
        {
            Console.WriteLine("MENU\n");
            foreach (var item in comboList)
            {
                Console.WriteLine($"Combo {item.ID}\n");
                Console.WriteLine($"Pollo: {item.chicken.getName()}\n");
                Console.WriteLine($"Drink: {item.drink.getName()}\n-------------");
            }
        }
        public async void menu(List<Combo<T>> combos, Chef<T> chef)
        {
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
                        var order = new Order();
                        order = takeOrder();
                        chef.receiveOrder(order);
                        chef.PrepareCombo(chef.OrderQ.Enqueue)
                }
            }
            while (opcion != "0");
        }
    }
}
