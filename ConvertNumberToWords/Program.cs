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

            const int TEENS_FROM = -19;
            const int TEENS_TO = 19;

            const int TENS_FROM = -90;
            const int TENS_TO = 90;

            Console.WriteLine("Sveiki!");

            string numberInput = "";
            string numberText = "";

            while (numberInput != " ")
            {
                Console.WriteLine($"Iveskite skaiciu nuo {FROM_NUMBER} iki {TO_NUMBER}.   (Iveskite Space programai uzbaigti.)");
                numberInput = Console.ReadLine();

                // TODO :au jusu programa!
                Console.WriteLine(ChangeNumberToText(numberInput, FROM_NUMBER, TO_NUMBER, TEENS_FROM, TEENS_TO, TENS_FROM, TENS_TO));

            }
            
            Console.WriteLine("Viso gero!");
            Console.ReadKey();
        }
        static string ChangeNumberToText(string numberInput, int FROM_NUMBER, int TO_NUMBER, int TEENS_FROM, int TEENS_TO, int TENS_FROM, int TENS_TO)
        {
            int testNumber;
            string numberText = "";
            string resultFormat;
            string resultInRange;
            //testNumber = Convert.ToInt32(numberText);

            if (CheckIfGoodNumber(numberInput, FROM_NUMBER, TO_NUMBER))
            {
                testNumber = Convert.ToInt32(numberInput);
                resultFormat = "Correct format";
           
                if (CheckIfNumberInRange(testNumber, FROM_NUMBER, TO_NUMBER))
                {
                    resultInRange = "Number in range ";
                }
                else
                    resultInRange = "Number not in range ";

                Console.WriteLine("Range result:"+ numberInput + " " + resultInRange + " " + CheckIfNumberInRange(testNumber, FROM_NUMBER, TO_NUMBER));
                  

                Console.WriteLine("Text: ");
                //ones
                if (testNumber>= FROM_NUMBER && testNumber <= TO_NUMBER)
                {
                    Console.WriteLine(testNumber + " " + ChangeOnesToText(testNumber, FROM_NUMBER, TO_NUMBER));
                }

                //teens
                else if ((testNumber >= TEENS_FROM && testNumber < FROM_NUMBER) || (testNumber > TO_NUMBER && testNumber <= TEENS_TO))
                {             
                    Console.WriteLine(testNumber + " " + ChangeTeensToText(testNumber, TEENS_FROM, TEENS_TO));
                }

                //tens
                else if ((testNumber >= TENS_FROM && testNumber < TEENS_FROM) || (testNumber > TEENS_TO && testNumber <= TENS_TO))
                {
                    //35
                    Console.WriteLine(testNumber + " " + ChangeTensToText(testNumber, TENS_FROM, TENS_TO));
                }
                
            }
             
            else
                resultFormat = "Incorrect format";
            
            Console.WriteLine("Format result "+ numberInput + " " + resultFormat + " " + CheckIfGoodNumber(numberInput, FROM_NUMBER, TO_NUMBER));
            return numberText;
        }

        static bool CheckIfGoodNumber(string numberInput, int FROM_NUMBER, int TO_NUMBER)
        {
            /*
            bool goodNumber = false;
            for (int i = FROM_NUMBER; i <= TO_NUMBER; i++)
            {

                if(Convert.ToString(i) == numberInput)
                {
                    goodNumber = true;
                }

            }
            return goodNumber;
            */
            /*
             if (numberInput.All(char.IsDigit))
                 goodNumber = true;
             else
                 goodNumber = false;

             return goodNumber;
             */

            int i = 0;
            bool result = int.TryParse(numberInput, out i);
            return result;
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

        static string ChangeOnesToText(int testNumber, int FROM_NUMBER, int TO_NUMBER)
        {
            string ones = "";
            if (testNumber == 0)
                ones = "nulis";

            else if (testNumber != 0 && testNumber <= TO_NUMBER && testNumber>= FROM_NUMBER)
            {
                if (testNumber == 1 || testNumber == -1)
                ones = "Vienas";
                else if (testNumber == 2 || testNumber == -2)
                ones = "Du";
                else if (testNumber == 3 || testNumber == -3)
                ones = "Trys";
                else if (testNumber == 4 || testNumber == -4)
                 ones = "Keturi";
                else if (testNumber == 5 || testNumber == -5)
                    ones = "Penki";
                else if (testNumber == 6 || testNumber == -6)
                    ones = "Sesi";
                else if (testNumber == 7 || testNumber == -7)
                    ones = "Septyni";
                else if (testNumber == 8 || testNumber == -8)
                    ones = "Astuoni";
                else if (testNumber == 9 || testNumber == -9)
                 ones = "Devyni";

                if (testNumber < 0)
                {
                    ones = "Minus "+ ones;
                }
            }
            return ones;    
        }

        static string ChangeTeensToText(int testNumber, int TEENS_FROM, int TEENS_TO)
        {
            string teens = "";
                if (testNumber == 10 || testNumber == -10)
                    teens = "Vienuolika";
                else if (testNumber == 11 || testNumber == -11)
                    teens = "Vienuolika";
                else if (testNumber == 12 || testNumber == -12)
                    teens = "Dvylika";
                else if (testNumber == 13 || testNumber == -13)
                    teens = "Trylika";
                else if (testNumber == 14 || testNumber == -14)
                    teens = "Keturiolika";
                else if (testNumber == 15 || testNumber == -15)
                    teens = "Penkiolika";
                else if (testNumber == 16 || testNumber == -16)
                    teens = "Sesiolika";
                else if (testNumber == 17 || testNumber == -17)
                    teens = "Septyniolika";
                else if (testNumber == 18 || testNumber == -18)
                    teens = "Astuoniolika";
                else if (testNumber == 19 || testNumber == -19)
                    teens = "Devyniolika";
                if (testNumber < 0)
                {
                    teens = "Minus " + teens;
                }
            
            return teens;
        }
        static string ChangeTensToText(int testNumber, int TENS_FROM, int TENS_TO)
        {
            string tens = "";

            if (testNumber >= 20 && testNumber <=29 || testNumber >= -29 && testNumber <= -20)
                tens = "Dvidesimt";
            else if (testNumber == 30 || testNumber == -30)
                tens = "Trisdesimt";
            else if (testNumber == 40 || testNumber == -40)
                tens = "Keturiasdesimt";
            else if (testNumber == 50 || testNumber == -50)
                tens = "Penkiasdesimt";
            else if (testNumber == 60 || testNumber == -60)
                tens = "Sesiolika";
            else if (testNumber == 70 || testNumber == -70)
                tens = "Septyniasdesimt";
            else if (testNumber == 80 || testNumber == -80)
                tens = "Astuoniasdesimt";
            else if (testNumber == 90 || testNumber == -90)
                tens = "Devyniasdesimt";
            if (testNumber < 0)
            {
                tens = "Minus " + tens;
            }

            return tens;
        }
        // bendra funkcija apjungti visom funkcijom kurias jus sukursit.
        // ... ChangeNumberToText()+

        // funkcija gauna string skaiciu, patikrina ar skaicius teisingu formatu. Pvz: "123", "-123" grazina true. "12a3", "1-23" grazina false.
        // ... CheckIfGoodNumber(...)+

        // funkcija grazina true jei skaicius checkNumber yar tarp fromNumber ir toNumber (imtinai)
        // ... CheckIfNumberInRange(...)+

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
