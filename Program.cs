namespace IDP_assg_3
{
    internal class Program
    {

        class Grundämne
        {

            public string namn, typ;
            public int z;
            public double smältpunkt, kokpunkt;

            public void Print()
            {
                Console.Write(" " + namn + "  ");
                Console.Write($"{typ} ");
                Console.WriteLine(typ + "  " + typ);
            }

        }


        static void Main(string[] args)
        {

            Grundämne syre = new Grundämne() { namn = "syre", z = 8, typ = "ickemetall", smältpunkt = 54.36, kokpunkt = 90.188};



        }
    }
}
