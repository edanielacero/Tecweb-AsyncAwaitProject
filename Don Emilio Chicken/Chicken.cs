using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_Emilio_Chicken
{
    public class Chicken
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
    public class Pollito : Chicken
    {
        public override string getName()
        {
            return "Pollito";
        }
        public override int getTime()
        {
            return 10000;
        }
    }
    public class PolloNormal : Chicken
    {
        public override string getName()
        {
            return "Pollo Normal";
        }
        public override int getTime()
        {
            return 20000;
        }
    }
    public class PollexPremium : Chicken
    {
        public override string getName()
        {
            return "Pollex Premium";
        }
        public override int getTime()
        {
            return 30000;
        }
    }
}
