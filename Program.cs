using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbas1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Console.WriteLine("--- === *** The number converter *** === ---");
            Console.WriteLine();

            Console.WriteLine("Iveskite numeri konvertavimui (reziuose -9 < numeris < 9):");
            input = Console.ReadLine();

            if (CheckIfNumber(input, out int parsedNumber))
            {
                if (CheckIfInBounds(parsedNumber, 9))
                {
                    Console.WriteLine($"Skaicius zodziais (intervalas [-9:9]): {ConvertNumberToWords(parsedNumber)}");
                }
                else if (CheckIfInBounds(parsedNumber, 19))
                {
                    Console.WriteLine($"Skaicius zodziais (intervalas [-19:19]): {ConvertNumberToWords(parsedNumber)}");
                }
                else if (CheckIfInBounds(parsedNumber, 999999999))
                {
                    Console.WriteLine($"Skaicius zodziais (intervalas [-999999999:999999999]):\n {ConvertNumberToWords(parsedNumber)}");
                }
                else
                {
                    Console.WriteLine("Per didelis intervalas, neisparsinsiu.");
                }
            }
            else
            {
                Console.WriteLine("Rezultatas ne skaicius");
            }


            Console.ReadKey();
        }

        static bool CheckIfInBounds(int NoToCheck, int bounds)
        {
            return NoToCheck >= (-bounds) && NoToCheck <= bounds ? true : false;
        }

        private static string ConvertNumberToWords(int parsedNumber)
        {
            string numberConverted = "";
            //999 999 999
            int units = 0;
            int tens = 0; 
            int hundrets = 0;
            int thousands = 0;
            int milions = 0;

            DecomposeNumberToParts(Math.Abs(parsedNumber), ref units, ref tens, ref hundrets, ref thousands, ref milions);
            int unitsH = units; int tensH = tens; int hundretsH = hundrets;
            if (milions > 0)
            {
                DecomposeNumberToParts(milions, ref units, ref tens, ref hundrets);
                numberConverted += ParseHundrets(units, tens, hundrets) + (units == 1 ? " milijonas " : units == 0 ? " milijonu" : " milijonai ");
            }
            if (thousands > 0)
            {
                DecomposeNumberToParts(thousands, ref units, ref tens, ref hundrets);
                numberConverted += ParseHundrets(units, tens, hundrets) + (units == 1 ? " tukstantis " : units == 0 ? " tukstanciu" : " tukstanciai ");
            }

            numberConverted += ParseHundrets(unitsH, tensH, hundretsH);

            return parsedNumber <  0 ? $"minus {numberConverted}" : numberConverted;
        }

        private static string ParseHundrets(int units, int tens, int hundrets)
        {
            string result = "";
            if (hundrets > 0)
            {
                result = ParseUnits(hundrets, false) + (hundrets == 1 ? "simtas " : "simtai ");
            }
            
            result += (tens == 1 ? ParseNiolika(units) : ParseTens(units, tens));

            return result;

        }

        private static string ParseNiolika(int units)
        {
            string result = "";

            switch (units)
            {
                case 1:
                    result = "vienuolika ";
                    break;
                case 2:
                    result = " dvylika ";
                    break;
                case 3:
                    result = " trylika ";
                    break;
                case 4:
                    result = " keturiolika ";
                    break;
                case 5:
                    result = " penkiolika ";
                    break;
                case 6:
                    result = " sesiolika ";
                    break;
                case 7:
                    result = " septyniolika ";
                    break;
                case 8:
                    result = " astuoniolika ";
                    break;
                case 9:
                    result = " devyniolika ";
                    break;
                default:
                    break;
            }

            return result;
        }

        private static string ParseTens(int units, int tens)
        {
            string result = "";

            switch (tens)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    result = " dvidesimt ";
                    break;
                case 3:
                    result = " trisdesimt ";
                    break;
                case 4:
                    result = " keturesdesimt ";
                    break;
                case 5:
                    result = " penkiasdesimt ";
                    break;
                case 6:
                    result = " sesesdesimt ";
                    break;
                case 7:
                    result = " septynesdesimt ";
                    break;
                case 8:
                    result = " astuonesdesimt ";
                    break;
                case 9:
                    result = " devynesdesimt ";
                    break;
                default:
                    break;
            }

            return result + (tens == 1 ? ParseNiolika(units) : ParseUnits(units));
        }

        private static string ParseUnits(int units, bool returnIfOne = true)
        {
            string result = "";

            switch (units)
            {
                case 1:
                    result = returnIfOne ? "vienas" : "";
                    break;
                case 2:
                    result = " du ";
                    break;
                case 3:
                    result = " trys ";
                    break;
                case 4:
                    result = " keturi ";
                    break;
                case 5:
                    result = " penki ";
                    break;
                case 6:
                    result = " sesi ";
                    break;
                case 7:
                    result = " septyni ";
                    break;
                case 8:
                    result = " astuoni ";
                    break;
                case 9:
                    result = " devyni ";
                    break;
                default:
                    break;
            }

            return result;
        }

        private static void DecomposeNumberToParts(int parsedNumber, ref int units, ref int tens, ref int hundrets, ref int thousands, ref int milions)
        {
            milions = (parsedNumber - (parsedNumber % 1000000)) / 1000000;
            parsedNumber = parsedNumber - (milions*1000000);
            thousands = (parsedNumber - (parsedNumber % 1000)) / 1000;
            parsedNumber = parsedNumber - (thousands * 1000);
            DecomposeNumberToParts(parsedNumber, ref units, ref tens, ref hundrets);

            //Console.WriteLine(milions);
            //Console.WriteLine(thousands);
            //Console.WriteLine(hundrets);
            //Console.WriteLine(tens);
            //Console.WriteLine(units);
        }

        private static void DecomposeNumberToParts(int parsedNumber, ref int units, ref int tens, ref int hundrets)
        {
            hundrets = (parsedNumber - (parsedNumber % 100)) / 100;
            parsedNumber = parsedNumber - (hundrets * 100);
            tens = (parsedNumber - (parsedNumber % 10)) / 10;
            parsedNumber = parsedNumber - (tens * 10);
            units = parsedNumber;
        }

        private static bool CheckIfNumber(string input, out int parsedNumber)
        {
            parsedNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && (int)input[i] == 45) continue;
                if ((int)input[i] > 57 || (int)input[i] < 48 )
                {
                    return false;
                }
            }
            parsedNumber = Convert.ToInt32(input);
            return true;
        }      
    }
}
