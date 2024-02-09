using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema17prkt1_2_
{
    class Press
    {
        int copiess;
        string name;
        double price;

        public int Copiess
        {
            get { return copiess; }
            set { copiess = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Press() { }
        public Press(int copiess,string name,double price)
        {
            this.copiess = copiess;
            this.name = name;
            this.price = price;
        }

        public double Cost()
        {
            return price*copiess ;
        }
        virtual public void OutPut()
        {
            WriteLine($" Стоимость тиража: {Cost()} \nКол-во копий: {copiess}\nНазвание: {name}\nЦена: {price}");
        }
    }
}
