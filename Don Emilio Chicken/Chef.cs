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
    }
}
