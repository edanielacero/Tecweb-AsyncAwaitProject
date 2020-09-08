using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_Emilio_Chicken
{
    class Program
    {
        public static List<Combo<int>> createCombos()
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

        static void Main(string[] args)
        {
            var combos = createCombos();
            var cashier = new Cashier<int>();
            var chef = new Chef<int>();

        }
    }
}
