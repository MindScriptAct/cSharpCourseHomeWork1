using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberToWords
{
    class Program
    {
        static void Main()
        {
            // TODO : keiskite FROM..TO skaicius pagal tai kiek spesite padaryt uzduociu. (-19...19, -99..99, ir tt.)
            const int FROM_NUMBER = -999;
            const int TO_NUMBER = 999;

            Console.WriteLine("Sveiki!");

            string numberInput = "";

            while (numberInput != " ")
            {
                Console.WriteLine($"Iveskite skaiciu nuo {FROM_NUMBER} iki {TO_NUMBER}.   (Iveskite Space programai uzbaigti.)");
                numberInput = Console.ReadLine();
                int num = Convert.ToInt32(numberInput);
                string zodziai;
                CheckIfGoodNumber(numberInput);
                CheckIfNumberInRange(numberInput);
                zodziai = ChangeNumberToText(num);
                Console.WriteLine(zodziai);



            }
            Console.WriteLine("Viso gero!");
            Console.ReadKey();

        }

        //KOMENTARAS//
        // Funkcija patikrina visus ivestus simbolius ir jei randa ivesta raide grazina false.
        //Jei nerandaraidziu grazina true


        static bool CheckIfGoodNumber(string input)
        {

            for (int i = 0; i < input.Length; i++)

            {

                char value = input[i];




                if (Char.IsLetter(value))
                {
                    Console.WriteLine("false");
                    return false;
                }

            }
            Console.WriteLine("true");
            return true;

        }



        // Funkcija patikrina ar ivestas skaicius yra duotose reziuose



        static int CheckIfNumberInRange(string input)
        {
            int temp = Convert.ToInt32(input);

            if (temp >= -999 && temp <= 999)
            {
                Console.WriteLine("Jusu ivestas skaicius tinkamas");
                return temp;
            }
            else
            {
                Console.WriteLine("Jusu ivestas skaicius netinkamas");
            }
            return 0;
        }
        // FUNKCIJA grazina ivesta INT zodiniu formatu
        static string ChangeNumberToText(int input)
        {


            if (input < 0)
                return "Minus " + ChangeNumberToText(-input);
            else if (input == 0)
                return "nulis";
            else if (input <= 19)
                return new string[] {"vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni",
               "devyni", "desimt", "vienuolika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika",
               "septyniolika", "astuoniolika", "devyniolika"}[input - 1] + "";
            else if (input <= 99)
                return new string[] {"dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt",
               "astuoniasdesimt", "devyniasdesimt"}[input / 10 - 2] + " " + ChangeNumberToText(input % 10);
            else if (input <= 199)
                return "Simtas " + ChangeNumberToText(input % 100);
            else if (input <= 999)
                return ChangeNumberToText(input / 100) + " simtai " + ChangeNumberToText(input % 100);
            else if (input <= 1999)
                return "Vienas tukstantis " + ChangeNumberToText(input % 1000);
            else if (input <= 999999)
                return ChangeNumberToText(input / 1000) + " Tukstanciai " + ChangeNumberToText(input % 1000);
            else if (input <= 1999999)
                return "Vienas milijonas " + ChangeNumberToText(input % 1000000);
            else if (input <= 999999999)
                return ChangeNumberToText(input / 1000000) + " Milijonai " + ChangeNumberToText(input % 1000000);
            else if (input <= 1999999999)
                return "Vienas milijardas " + ChangeNumberToText(input % 1000000000);
            else
                return ChangeNumberToText(input / 1000000000) + " Milijardai " + ChangeNumberToText(input % 1000000000);
        }
    }

}





