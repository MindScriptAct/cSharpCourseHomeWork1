using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string ivestasTekstas = "";
            int skaicius = 0;

            Console.WriteLine("Pirmas namu darbas. Pirma dalis\n Iveskite skaiciu nuo -9 iki 9 :");
            ivestasTekstas = Ivedimas(ivestasTekstas);

            Console.WriteLine($"Ar ivestas skaicius? : {PatikrinimasArTaiSkaicius(ivestasTekstas)}");
            //bool patikrinimas = PatikrinimasArTaiSkaicius(ivestasTekstas);
            if (PatikrinimasArTaiSkaicius(ivestasTekstas) == false)
            {
                Console.WriteLine("Ivedete neteisingai. Jusu operacija baigta");
            }
            else
            {
                skaicius = Convert.ToInt32(ivestasTekstas);
                Console.WriteLine($"Ar ivestas skaicius yra reziuose? : {PatikrinimasArReziuose(ivestasTekstas)}");
                Console.WriteLine();
                //---------------------------------------------------------------------
                if (PatikrinimasArReziuose(ivestasTekstas) == true)
                {
                    Console.WriteLine("Antra dalis\nIvestas skaicius zodziais:");
                    Console.WriteLine(Konvertavimas9(skaicius));
                }
                else
                {
                    Console.WriteLine("Skaiciaus konvertuoti negalime, nes jis ne reziuose nuo -9 iki 9");
                }
            }
            Console.WriteLine();
            //---------------------------------------------------------------------
            Console.WriteLine("Trecia dalis\nIveskite skaiciu nuo -19 iki 19:");
            int ivestasDidesnisSkaicius = Convert.ToInt32(Console.ReadLine());
            if (ivestasDidesnisSkaicius > -20 && ivestasDidesnisSkaicius < 20)
            {
                Console.WriteLine(Konvertavimas19(ivestasDidesnisSkaicius));
            }
            else // nebaigta su papildomomis uzduotimis su didesniais skaiciais
            {
                Console.WriteLine($"iskvieciam didesne funkcija: {Konvertavimas99(ivestasDidesnisSkaicius)}");
            }
            Console.ReadKey();
        }

        //---------------------------------------------------------------------
        static string Ivedimas(string tekstas)
        {
            return tekstas = Console.ReadLine();
        }
        //---------------------------------------------------------------------
        static bool PatikrinimasArTaiSkaicius(string ivestasTekstas)
        {
            bool patikrinimas = false;
            for (int i = 0; i < ivestasTekstas.Length; i++)
            {
                if (ivestasTekstas[i] == '-' && Convert.ToInt32(ivestasTekstas[i + 1]) >= '0' && Convert.ToInt32(ivestasTekstas[i + 1]) <= '9' || Convert.ToInt32(ivestasTekstas[i]) >= '0' && Convert.ToInt32(ivestasTekstas[i]) <= '9')
                {
                    patikrinimas = true;
                }
                else
                {
                    patikrinimas = false;
                    break;
                }
            }
            return patikrinimas;
        }
        //---------------------------------------------------------------------
        static bool PatikrinimasArReziuose(string ivestasZodis)
        {
            int skaicius = Convert.ToInt32(ivestasZodis);
            bool arSkaiciusReziuose = false;
            if (skaicius > -10 && skaicius < 10)
            {
                arSkaiciusReziuose = true;
            }
            else
            {
                arSkaiciusReziuose = false;
            }
            return arSkaiciusReziuose;
        }
        //---------------------------------------------------------------------
        static string Konvertavimas9(int ivestasSkaicius)
        {
            string tekstas = "";
            string skaicius = Convert.ToString(ivestasSkaicius);
            if (ivestasSkaicius < 0)
            {
                skaicius = skaicius.Substring(1, skaicius.Length - 1);
            }
            switch (skaicius)
            {
                case "1":
                    tekstas = "vienas";
                    break;
                case "2":
                    tekstas = "du";
                    break;
                case "3":
                    tekstas = "trys";
                    break;
                case "4":
                    tekstas = "keturi";
                    break;
                case "5":
                    tekstas = "penki";
                    break;
                case "6":
                    tekstas = "sesi";
                    break;
                case "7":
                    tekstas = "septyni";
                    break;
                case "8":
                    tekstas = "astuoni";
                    break;
                case "9":
                    tekstas = "devyni";
                    break;
            }
            if (ivestasSkaicius > 0)
            {
                return tekstas;
            }
            else if (ivestasSkaicius < 0)
            {
                return "Minus" + " " + tekstas;
            }
            else
            {
                return "Nulis";
            }
        }
        //---------------------------------------------------------------------
        static string Konvertavimas19(int ivestasSkaicius)
        {
            string tekstas = "";
            string skaicius = Convert.ToString(ivestasSkaicius);
            if (ivestasSkaicius < 0)
            {
                skaicius = skaicius.Substring(1, skaicius.Length - 1);
            }
            switch (skaicius)
            {
                case "10":
                    tekstas = "desimt";
                    break;
                case "11":
                    tekstas = "vienuolika";
                    break;
                case "12":
                    tekstas = "dvylika";
                    break;
                case "13":
                    tekstas = "trylika";
                    break;
                case "14":
                    tekstas = "keturiolika";
                    break;
                case "15":
                    tekstas = "penkiolika";
                    break;
                case "16":
                    tekstas = "sesiolika";
                    break;
                case "17":
                    tekstas = "septyniolika";
                    break;
                case "18":
                    tekstas = "astuoniolika";
                    break;
                case "19":
                    tekstas = "devyniolika";
                    break;
            }
            if (ivestasSkaicius > 0)
            {
                return tekstas;
            }
            else if (ivestasSkaicius < 0)
            {
                return "Minus" + " " + tekstas;
            }
            else
            {
                return "Nulis";
            }
        }
        //---------------------------------------------------------------------
        static string Konvertavimas99(int ivestasSkaicius)
        {
            string tekstas = "";
            string skaicius = Convert.ToString(ivestasSkaicius);
            if (ivestasSkaicius < 0)
            {
                skaicius = skaicius.Substring(1, skaicius.Length - 1);
            }
            switch (skaicius)
            {
                case "10":
                    tekstas = "desimt";
                    break;
                case "20":
                    tekstas = "dvidesimt";
                    break;
                case "30":
                    tekstas = "trisdesimt";
                    break;
                case "40":
                    tekstas = "keturiasdesimt";
                    break;
                case "50":
                    tekstas = "penkiasdesimt";
                    break;
                case "60":
                    tekstas = "sesiasdesimt";
                    break;
                case "70":
                    tekstas = "septyniasdesimt";
                    break;
                case "80":
                    tekstas = "astuoniasdesimt";
                    break;
                case "90":
                    tekstas = "devyniasdesimt";
                    break;
            }
            // nebaigta su papildomomis uzduotimis su didesniais skaiciais
            if (ivestasSkaicius > 0)
            {
                return tekstas + " "; //+ Konvertavimas9(Convert.ToString(ivestasSkaicius));
            }
            else if (ivestasSkaicius < 0)
            {
                return "Minus" + " " + tekstas; // + Konvertavimas9(Convert.ToString(ivestasSkaicius)[2]);
            }
            else
            {
                return "Nulis";
            }
        }

    }
}