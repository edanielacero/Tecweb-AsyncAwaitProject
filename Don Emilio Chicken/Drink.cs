using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_Emilio_Chicken
{
    public class Drink
    {
        public virtual string getName()
        {
            return string.Empty;
        }
        public virtual int getTime()
        {
            return 0;
        }
    }
    public class Coke : Drink
    {
        public override string getName()
        {
            return "Coca Cola";
        }

        public override int getTime()
        {
            return 3000;
        }
    }
    public class Limonada : Drink
    {
        public override string getName()
        {
            return "Limonada";
        }

        public override int getTime()
        {
            return 5000;
        }
    }
    public class Juice : Drink
    {
        public override string getName()
        {
            return "Jugo Exotico";
        }

        public override int getTime()
        {
            return 10000;
        }
    }
}
