using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Coin
    {
        private string _side;

        public Coin()
        {
            _side = "Heads";
        }

        public string Side
        {
            get { return _side; }
            set { _side = value; }
        }

        Random rand = new Random();
        public void Toss()
        {
            if (rand.Next(2) == 0)
                _side = "Heads";
            else
                _side = "Tails";
        }

    }
}
