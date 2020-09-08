using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Don_Emilio_Chicken
{
    class Chef<T>
    {
        public Queue<Order> OrderQ { get; set; }

        public void receiveOrder(Order orderReceived)
        {
            OrderQ.Enqueue(orderReceived);
        }
        public async Task<string> PrepareChickenAsync(Combo<T> combo)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"preparando {combo.chicken.getName()}");
                Thread.Sleep(combo.chicken.getTime());
            });
            return combo.chicken.getName();
        }

        public async Task<string> PrepareDrinkAsync(Combo<T> combo)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"sirviendo {combo.drink.getName()}");
                Thread.Sleep(combo.drink.getTime());
            });
            return combo.drink.getName();
        }
        public async void PrepareCombo(Combo<T> combo)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"preparando {combo.chicken.getName()}");
                Thread.Sleep(combo.chicken.getTime());
                Console.WriteLine($"sirviendo {combo.drink.getName()}");
                Thread.Sleep(combo.drink.getTime());
            });
        }
    }
}
