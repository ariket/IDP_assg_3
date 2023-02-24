﻿namespace IDP_assg_3
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
                Console.WriteLine("Grundämne: " + namn + "  ");
                Console.WriteLine($"  Typ: {typ} ");
                Console.WriteLine("  Smältpunkt: " + smältpunkt + " K");
                Console.WriteLine("  Kokpunkt: " + kokpunkt + " K");
            }

        }


        static void Main(string[] args)
        {

            Grundämne syre = new Grundämne() { namn = "syre", z = 8, typ = "ickemetall", smältpunkt = 54.36, kokpunkt = 90.188};
            Grundämne järn = new Grundämne() { namn = "järn", z = 26, typ = "metall", smältpunkt = 1811, kokpunkt = 3134};
            Grundämne guld = new Grundämne() { namn = "guld", z = 79, typ = "metall", smältpunkt = 1337.33, kokpunkt = 3243};

            syre.Print();
            järn.Print();
            guld.Print();


            Grundämne[] Grundämnen = new Grundämne[6] { syre, järn, guld,
            new Grundämne() { namn = "väte", z = 1, typ = "ickemetall", smältpunkt = 13.99, kokpunkt = 20.271 },
            new Grundämne() { namn = "brom", z = 35, typ = "ickemetall", smältpunkt = 265.8, kokpunkt = 332.0 },
            new Grundämne() { namn = "kvicksilver", z = 80, typ = "metall", smältpunkt = 234.321, kokpunkt = 629.88 }};
            

        }
    }
}
