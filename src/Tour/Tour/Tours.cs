using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    class Tours
    {
        public string poezdka;
        public string prodol;
        public string price;

        public Tours()
        {
            this.poezdka = "";
            this.prodol = "";
            this.price = "";
        }

        public string Poezdka
        {
            get { return this.poezdka; }
            set { this.poezdka = value; }
        }
        public string Prodol
        {
            get { return this.prodol; }
            set { this.prodol = value; }
        }
        public string Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
