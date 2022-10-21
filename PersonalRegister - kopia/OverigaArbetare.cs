using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class OverigaArbetare : ArbetareAbs, IArbetare
    {

        string info;


        public OverigaArbetare(string name, string efternamn, int id) : base(name, efternamn, id)
        {
        }

        //private String name { get; set; }
        //private String efternamn { get; set; }
        //private int Id { get; set; }


        public bool isArbetareHasSkor()
        {
            Console.WriteLine("Vill du skkyd Skor , svara 1 för jaa eller 0 för nej Tack!");
            int input;
            input = Convert.ToInt32(Console.ReadLine());


            if (input == 1)
            {
                Console.WriteLine("Tack ! du har skor nu");
                return true;
            }
            else if (input == 0)
            {
                Console.WriteLine("Tack ! du har  inga skor nu");
                return false;
            }
            else
            {
                Console.WriteLine("Fel inträffat");
            }

            return (false);
        }

        public override string getArbetare()
        {
            return info = "Arbetaren's Full namn är :  " + getName() + getEfternamn() + "\n" + " ID till användaren är : " + getId() + "\n" + " Arbetaren är typen of : " + getDescription() + isArbetareHasSkor();
            //throw new NotImplementedException();
        }

        public string getDescription()
        {
            return "Överiga";
        }

        public override string getEfternamn()
        {
            return efternamn;
        }

        public override int getId()
        {
            return Id;
        }

        public override string getName()
        {
            return name;
        }
    }
}
