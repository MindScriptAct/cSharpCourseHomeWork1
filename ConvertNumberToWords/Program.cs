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

            const int TENS_FROM = -99;
            const int TENS_TO = 99;

            const int HUNDREDS_FROM = -999;
            const int HUNDREDS_TO = 999;

            const int THOUSANDS_FROM = -999999;
            const int THOUSANDS_TO = 999999;

            Console.WriteLine("Sveiki!");

            string numberInput = "";
            string numberText = "";

            while (numberInput != " ")
            {
                Console.WriteLine($"Iveskite skaiciu nuo {FROM_NUMBER} iki {TO_NUMBER}.   (Iveskite Space programai uzbaigti.)");
                numberInput = Console.ReadLine();

                // TODO :au jusu programa!
                Console.WriteLine(ChangeNumberToText(numberInput, FROM_NUMBER, TO_NUMBER, TEENS_FROM, TEENS_TO, TENS_FROM, TENS_TO, HUNDREDS_FROM, HUNDREDS_TO, THOUSANDS_FROM, THOUSANDS_TO));

            }
            
            Console.WriteLine("Viso gero!");
            Console.ReadKey();
        }
        static string ChangeNumberToText(string numberInput, int FROM_NUMBER, int TO_NUMBER, int TEENS_FROM, int TEENS_TO, int TENS_FROM, int TENS_TO, int HUNDREDS_FROM, int HUNDREDS_TO ,int THOUSANDS_FROM, int THOUSANDS_TO)
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
                    Console.WriteLine(testNumber + " " + CheckIfMinus(testNumber)+" "+ChangeOnesToText(testNumber, FROM_NUMBER, TO_NUMBER));
                }

                //teens
                else if ((testNumber >= TEENS_FROM && testNumber < FROM_NUMBER) || (testNumber > TO_NUMBER && testNumber <= TEENS_TO))
                {             
                    Console.WriteLine(testNumber + " " + CheckIfMinus(testNumber) + " " + ChangeTeensToText(testNumber, TEENS_FROM, TEENS_TO));
                }

                //tens
                else if ((testNumber >= TENS_FROM && testNumber < TEENS_FROM) || (testNumber > TEENS_TO && testNumber <= TENS_TO))
                {
                    Console.WriteLine(testNumber + " " + CheckIfMinus(testNumber) + " " + ChangeTensToText(testNumber, FROM_NUMBER, TO_NUMBER));
                }
                //hundreds
                else if ((testNumber >= HUNDREDS_FROM && testNumber < TENS_FROM) || (testNumber > TENS_TO && testNumber <= HUNDREDS_TO))
                {
                    Console.WriteLine(testNumber + " " + CheckIfMinus(testNumber) + " " + ChangeHundredsToText(testNumber, FROM_NUMBER, TO_NUMBER, TEENS_FROM, TEENS_TO, HUNDREDS_FROM, HUNDREDS_TO));
                }
                //thousands
                else if ((testNumber >= THOUSANDS_FROM && testNumber < HUNDREDS_FROM) || (testNumber > HUNDREDS_TO && testNumber <= THOUSANDS_TO))
                {
                    Console.WriteLine("TUKSTANTINIAI  ");
                    Console.WriteLine(testNumber + " " + CheckIfMinus(testNumber) + " " + ChangeThousandsToText(testNumber, FROM_NUMBER, TO_NUMBER, TEENS_FROM, TEENS_TO, TENS_FROM, TENS_TO,HUNDREDS_FROM,HUNDREDS_TO));
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

        static string CheckIfMinus(int testNumber)
        {
            string minus = "";
            if (testNumber < 0)
                minus = "Minus";

            return minus;
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
            }
            return ones;    
        }

        static string ChangeTeensToText(int testNumber, int TEENS_FROM, int TEENS_TO)
        {
            string teens = "";
                if (testNumber == 10 || testNumber == -10)
                    teens = "Desimt";
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
            return teens;

        }
        static string ChangeTensToText(int testNumber, int FROM_NUMBER, int TO_NUMBER)
        {

            string tens = "";
            int ones = testNumber % 10;

            if (testNumber >= 20 && testNumber <=29 || testNumber >= -29 && testNumber <= -20)
                tens = "Dvidesimt";
            else if (testNumber >= 30 && testNumber <= 39 || testNumber >= -39 && testNumber <= -30)
                tens = "Trisdesimt";
            else if (testNumber >= 40 && testNumber <= 49 || testNumber >= -49 && testNumber <= -40)
                tens = "Keturiasdesimt";
            else if (testNumber >= 50 && testNumber <= 59 || testNumber >= -59 && testNumber <= -50)
                tens = "Penkiasdesimt";
            else if (testNumber >= 60 && testNumber <= 69 || testNumber >= -69 && testNumber <= -60)
                tens = "Sesiasdesimt";
            else if (testNumber >= 70 && testNumber <= 79 || testNumber >= -79 && testNumber <= -70)
                tens = "Septyniasdesimt";
            else if (testNumber >= 80 && testNumber <= 89 || testNumber >= -89 && testNumber <= -80)
                tens = "Astuoniasdesimt";
            else if (testNumber >= 90 && testNumber <= 99 || testNumber >= -99 && testNumber <= -90)
                tens = "Devyniasdesimt";

            if (ones != 0)
            {
                tens= tens +" "+ ChangeOnesToText(ones, FROM_NUMBER, TO_NUMBER);
            }

            return tens;
        }
        static string ChangeHundredsToText(int testNumber, int FROM_NUMBER, int TO_NUMBER, int TEENS_FROM, int TEENS_TO, int HUNDREDS_FROM, int HUNDREDS_TO)
        {
            string hundreds = "";
            int tens = testNumber % 100;
            int teens = testNumber % 10;

            if (testNumber >= 100 && testNumber <= 199 || testNumber >= -199 && testNumber <= -100)
                hundreds = "Simtas";

            int div = testNumber / 100;
            if (div < 0)  div = div * -1; 
            for (int i=1; i<=9; i++)
            {
                if (div == i)
                {
                    hundreds = ChangeOnesToText(div, i, 9) + " Simtai";
                }
            }
           
            if (tens != 0)
            {
                if ((tens >= TEENS_FROM && tens < FROM_NUMBER) || (tens > TO_NUMBER && tens <= TEENS_TO))
                {
                    hundreds = hundreds + " " + ChangeTeensToText(tens, TEENS_FROM, TEENS_TO);
                }
                else
                hundreds = hundreds + " " + ChangeTensToText(tens, FROM_NUMBER, TO_NUMBER);
            }

            return hundreds;
        }

        static string ChangeThousandsToText(int testNumber, int FROM_NUMBER, int TO_NUMBER, int TEENS_FROM, int TEENS_TO, int TENS_FROM, int TENS_TO, int HUNDREDS_FROM, int HUNDREDS_TO)
        {
            string thousands = "";
            int hundreds = testNumber % 1000;
            int tens = testNumber % 10000;
            int ones = testNumber % 100000;

            if (testNumber >= 1000 && testNumber <= 1999 || testNumber >= -1999 && testNumber <= -1000)
                thousands = "Tukstantis";

            int div = testNumber / 1000;
            int divHundreds = testNumber / 1000;
            int decimals = testNumber / 10000;

            if (div < 0) div = div * -1;
            if (tens < 0) tens = tens * -1;

            for (int i = 1; i <= 9; i++)
            {
                if (div == i)
                {
                    thousands = ChangeOnesToText(div, i, 9) + " Tukstanciai";
                }
            }

            for (int i = 10; i <= 19; i++)
            {
                if (div == i)
                {
                    thousands = ChangeTeensToText(div, 10, 99) + " Tukstanciu";
                }
            }

            for (int i = 20; i <= 99; i++)
            {
                if (div == i)
                {
                    thousands = ChangeTensToText(div, 10, 99);
/*!!!QUESTION TO LECTURER:
                     *when we have ten thousands number (for example 25000), we are calling out function ChangeTensToText.
                     * Problem is that this function here is reading only tenth /1000 digit of 5 digit number, in this case
                     * form number  25000 it's reading 20, not 25.
                     * When I'm working with tens - same function is also called and it gives tenth digit, as well as ones.
                     * Why this is not happenning here and why I have additionally below call function named ChangeOnesToText to get ones digits.
 */
                    if (tens / 1000 == i % 10)
                        thousands = thousands + ChangeOnesToText(tens / 1000, i % 10, 9) + " Tukstanciai";

                    else {
                        thousands = thousands + " Tukstanciu";
                    } 
                }
            }

           //Console.WriteLine("hundredsthousands" + div);
            for (int i = 100; i <= 999; i++)
            {  
                if (div == i)
                {
                    thousands = ChangeHundredsToText(div, 1,9, 10, 19, 100, 999) + " Tukstanciu";                   
                }
            }

            if (hundreds != 0)
            {
                
                if ((hundreds >= HUNDREDS_FROM && hundreds < TENS_FROM) || (hundreds > TENS_TO && hundreds <= HUNDREDS_TO))
                {
                    thousands = thousands + " " + ChangeHundredsToText(hundreds, FROM_NUMBER, TO_NUMBER, TEENS_FROM, TEENS_TO, HUNDREDS_FROM, HUNDREDS_TO);
                }
                else if ((hundreds >= TEENS_FROM && hundreds < FROM_NUMBER) || (hundreds > TO_NUMBER && hundreds <= TEENS_TO))
                {
                    thousands = thousands + " " + ChangeTeensToText(hundreds, TEENS_FROM, TEENS_TO);
                }
                else if ((hundreds >= TENS_FROM && hundreds < TEENS_FROM) || (hundreds > TEENS_TO && hundreds <= TENS_TO))
                    thousands = thousands + " " + ChangeTensToText(hundreds, FROM_NUMBER, TO_NUMBER);
            }
            ///

            if (tens != 0)
            {
                if ((tens >= TENS_FROM && tens < TEENS_FROM) || (tens > TEENS_TO && tens <= TENS_TO))
                    thousands = thousands + "  " + ChangeTensToText(tens, FROM_NUMBER, TO_NUMBER);
            }

            ///

            return thousands;
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
