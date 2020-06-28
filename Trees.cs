using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_v6
{
    class Trees:Plants
    {
        public bool isAlive;
        public Trees (double dlina, int vozrast, bool isAlive) : base(null, dlina, vozrast)
        {
            this.isAlive = isAlive;
        }
        #region переопределение
        public override void get_inf()
        {
            base.get_inf();
            Console.WriteLine("Is alive: " + isAlive);
        }
        #endregion
        public Trees ():base() { }
    }
}
