using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinResa
{
    class Resor
    {
        private string land;
        private string flagga;

        public string Land
        {
            get { return land; }
            set {
                if (value == null)
                {
                    throw new NullReferenceException("Värdet är null");
                }
                land = value; }
        }
        

        public string Flagga
        {
            get { return flagga; }
            set { flagga = value; }
        }

        public Resor(string land, string flagga)
        {
            Land = land;
            Flagga = flagga;
        }

        public override string ToString()
        {
            return string.Format("", Land, Flagga);
        }

    }
}
