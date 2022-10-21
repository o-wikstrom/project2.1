using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public abstract class ArbetareAbs
    {
        public String name { get; private set; }
        public String efternamn {get; private set; }
        public int Id {get; private set; }

        public ArbetareAbs(string name, string efternamn, int id)
        {
            this.name = name;
            this.efternamn = efternamn;
            this.Id = id;

        }


        public abstract String getName();

        public abstract String getEfternamn();


        // get id
        public abstract int getId();


        public abstract String getArbetare();
      

    }
}
