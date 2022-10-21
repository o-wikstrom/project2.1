using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class ArbetsMyror : ArbetareAbs, IArbetare
    {


        string info;
  
 
        public ArbetsMyror(string name, string efternamn, int id) : base(name, efternamn, id)
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
            return "Arbets myror";
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








        //    private String fnamn { get; set; }
        //    private String enamn { get; set; }
        //    private int jobbid { get; set; }


        //    public String getFullnamn()
        //    {
        //        return getFullnamn();
        //    }

        //    public ArbetsMyror(String name, String efternamn, int id) : base(name, efternamn, id)
        //    {
        //        fnamn = name;
        //        enamn = efternamn;
        //        jobbid = id;

        //    }


        //    public String getName()
        //    {
        //        return getName();
        //    }


        //    public String getEfternamn()
        //    {
        //        return getEfternamn();
        //    }


        //    public int getId()
        //    {
        //        return getId();
        //    }

        //    public static bool isArbetareHasSkor()
        //    {
        //        Console.WriteLine("Vill du skkyd Skor , svara 1 för jaa eller 0 för nej Tack!");
        //        int input;
        //        input = Convert.ToInt32(Console.ReadLine());


        //        if (input == 1)
        //        {
        //            Console.WriteLine("Tack ! du har skor nu");
        //            return true;
        //        }
        //        else if (input == 0)
        //        {
        //            Console.WriteLine("Tack ! du har  inga skor nu");
        //            return false;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Fel inträffat");
        //        }

        //        return (false);
        //    }

        //    //method


        //    public String getDescription()
        //    {
        //        return "Myror";
        //    }


        //    //public String getArbetstyp()
        //    //{
        //    //    return getArbetstyp();
        //    //}


        //    public String getArbetare()
        //    {
        //        return fnamn = "Arbetaren's Full namn är :  " + getName() + getEfternamn() + "\n" + " ID till användaren är : " + getId() + "\n" + " Arbetaren är typen of : " + getDescription() + isArbetareHasSkor();

        //    }
        //}

    }
}
