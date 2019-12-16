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
            const int FROM_NUMBER = -9;
            const int TO_NUMBER = 9;

            Console.WriteLine("Sveiki!");

            string numberInput = "";
            string numberText = "";

            while (numberInput != " ")
            {
                Console.WriteLine($"Iveskite skaiciu nuo {FROM_NUMBER} iki {TO_NUMBER}.   (Iveskite Space programai uzbaigti.)");
                numberInput = Console.ReadLine();

               
                // TODO :au jusu programa!
                Console.WriteLine(ChangeNumberToText(numberInput, FROM_NUMBER, TO_NUMBER));

            }
            
            Console.WriteLine("Viso gero!");
            Console.ReadKey();
        }
        static string ChangeNumberToText(string numberInput, int FROM_NUMBER, int TO_NUMBER)
        {
            int testNumber;
            string numberText = "";

            //testNumber = Convert.ToInt32(numberText);

            if (CheckIfGoodNumber(numberInput, FROM_NUMBER, TO_NUMBER))
            {
                //change number to text
            }
            else
            {
                //Console.WriteLine(numberInput + " is incorrect format");
            }
            //bool goodNumber = CheckIfGoodNumber(testNumber, FROM_NUMBER, TO_NUMBER );

            /*
            if (numberInput == "-")
                numberText = "Minus";

            if (numberInput == "0")
                numberText = "Nulis";

            else if (numberInput == "1")
                numberText = "Vienas";

            else if(numberInput == "2")
                numberText = "Du";

            else if(numberInput == "3")
                numberText = "Trys";

            else if(numberInput == "4")
                numberText = "Keturi";

            else if(numberInput == "5")
                numberText = "Penki";

            else if(numberInput == "6")
                numberText = "Sesi";

            else if(numberInput == "7")
                numberText = "Septyni";

            else if(numberInput == "8")
                numberText = "Astuoni";

            else if(numberInput == "9")
                numberText = "Devyni";
            */
            return numberText;
        }

        static bool CheckIfGoodNumber(string numberInput, int FROM_NUMBER, int TO_NUMBER)
        {
           
            bool goodNumber = false;
            if (numberInput.All(char.IsDigit))
            {
                goodNumber = true;
                int testNumber = Convert.ToInt32(numberInput);
                bool numberInRange = CheckIfNumberInRange(testNumber, FROM_NUMBER, TO_NUMBER);

                if (numberInRange)
                {
                    Console.WriteLine(" number in range " + numberInRange);
                }
                //Console.WriteLine("good number " + numberInput);
            }
            else
                goodNumber = false;
            //Console.WriteLine("Bad input " + numberInput);

            return goodNumber;
            
        }

        static bool CheckIfNumberInRange(int testNumber, int FROM_NUMBER, int TO_NUMBER)
        {
            bool numberInRange = false;
            if (testNumber>= FROM_NUMBER && testNumber <= TO_NUMBER)
            {
                numberInRange = true;
            }
            return numberInRange;
        }

        // bendra funkcija apjungti visom funkcijom kurias jus sukursit.
        // ... ChangeNumberToText()

        // funkcija gauna string skaiciu, patikrina ar skaicius teisingu formatu. Pvz: "123", "-123" grazina true. "12a3", "1-23" grazina false.
        // ... CheckIfGoodNumber(...)

        // funkcija grazina true jei skaicius checkNumber yar tarp fromNumber ir toNumber (imtinai)
        // ... CheckIfNumberInRange(...)

        // idejos kitom funkcijoms
        //ChangeOnesToText(), ChangeTeensToText, ChangeTensToText, ChangeHundredsToText, ChangeThousandsToText, ChangeMillionsToText, ChangeBilllionsToText


        //Skaiciai zodziais:  
        // "minus"; 
        // "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni"; 
        // "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"; 
        // "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt"; 
        // "simtas", "tukstantis", "milijonas", "milijardas"; 
        // "simtai", "tukstanciai", "milijonai", "milijardai"; 
        // "simtu", "tukstanciu", "milijonu", "milijardu"; 
    }
}
