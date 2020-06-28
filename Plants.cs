using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_v6
{
    class Plants
    {
        #region поля+инкапсуляция
        public string tip { private set; get; }
        public double dlina { private set; get; }
        public int vozrast { private set; get; }
        public string color { private set; get; } = "green";
        #endregion

        #region методы установки и получения значений (есть virtual)
        public void sett(string tip, double dlina, int vozrast, string color)
        {
            this.tip = tip;
            this.dlina = dlina;
            this.vozrast = vozrast;
            this.color = color;
        }

        public void sett(string tip, double dlina, int vozrast)
        {
            this.tip = tip;
            this.dlina = dlina;
            this.vozrast = vozrast;
            this.color = color;
        }

        public static void pluss ()
        {
            Console.WriteLine("\nСоздайте собственный экземпляр класса");
            Plants n = new Plants();

            Console.Write("\nВведите тип растения: ");
            n.tip = Convert.ToString(Console.ReadLine());

            Console.Write("\nВведите длину растения: ");
            n.dlina = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите возраст растения: ");
            n.vozrast = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите цвет растения: ");
            n.color = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nДержите ваш экземпляр класса\n");

            n.get_inf();

            Console.WriteLine("\nОтлично, вы справились. Нажмите Enter для выхода");
        }

        public virtual void get_inf()
        {
            Console.WriteLine("\nТип: " + tip + "\nДлина: " + dlina + "\nВозраст: " + vozrast + "\nЦвет: " + color);
        }
        #endregion

        #region конструкторы + перегрузка
        public Plants(string tip, double dlina, int vozrast)
        {
            this.tip = tip;
            this.dlina = dlina;
            this.vozrast = vozrast;
        }

        public Plants(string tip, double dlina, int vozrast, string color)
        {
            this.tip = tip;
            this.dlina = dlina;
            this.vozrast = vozrast;
            this.color = color;
        }

        public Plants() { }
        #endregion

        #region static and virtual

        public static void Description ()
        {
            Console.WriteLine("Растения — многоклеточные организмы, способные к фотосинтезу");
        }

        #endregion
    }
}
