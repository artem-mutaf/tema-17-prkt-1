using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema17prkt1_2_
{
    class Maga:Press
    {
        string quality;
        public string Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public Maga() { }
        public Maga(string quality)
        {
            this.quality = quality;
        }
        public new double Cost()
        {
            
            if(quality=="Высокое")
            {
                return base.Cost() + ((base.Cost() / 100) * 10);
            }
            else if(quality=="Низкое")
            {
                return base.Cost() + ((base.Cost() / 100) * -10);
            }
            else
            {
                return base.Cost();
            }
        }
    }
}
