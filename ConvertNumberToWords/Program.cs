using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeWork_NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            const long FROM_NUMBER = -1000000000000000000;
            const long TO_NUMBER = 1000000000000000000;

            string inputString = "";
            long inputNumber = 0;

            Console.WriteLine("Sveiki!");

            while (inputString != " ")
            {
                Console.Write("\n(Enter SPACE to exit.)\nIveskite skaiciu:");
                Console.WriteLine();

                inputString = Console.ReadLine();

                if (inputString.Length < 18) // Kodel butent 18 ??
                {
                    if (CheckIfGoodNumber(inputString))
                    {
                        Console.WriteLine("Skaicius teisingas");
                        inputNumber = Convert.ToInt64(inputString);

                        if (CheckIfNumberInRange(FROM_NUMBER, TO_NUMBER, inputNumber))
                        {
                            Console.WriteLine($"Skaicius {inputNumber} zodziais:\n {ChangeNumberToText(inputNumber)}");
                        }
                        else
                        {
                            Console.WriteLine($"Blogas skaicius {inputString}, prasau ivesti skaiciu reziuose: {FROM_NUMBER}..{TO_NUMBER}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Ivesti duomenys:{inputString} nera skaicius!");
                    }
                }
                else
                {
                    Console.WriteLine($"Skaicius per ilgas, prasau ivesti skaiciu reziuose: {FROM_NUMBER}..{TO_NUMBER}");
                }

            }
            Console.WriteLine("\nAciu uz demesi, viso gero.");
            Console.ReadKey();



        }

        // FUNCTIONS


        static string ChangeNumberToText(long number)
        {
            string output = "";

            // patikrinu ar neigiamas skaicius ir paverciu tegiamu bei papildau outputa
            if (number < 0)
            {
                output = "Minus ";
                number *= -1;
            }

            if (number == 0)
            {
                return "Nulis";
            }

            // Data to print masyvuose

            string[] singular = { "tukstantis", "milijonas", "milijardas", "trilijonas", "kvadrilijonas" };
            string[] plural1 = { "tukstanciai", "milijonai", "milijardai", "trilijonai", "kvadrilijonai" };
            string[] plural2 = { "tukstanciu", "milijonu", "milijardu", "trilijonu", "kvadrilijonu" };

            long devider = 1000;
            int tripletIndex = 0;

            for (int i = 0; i < singular.Length; i++)
            {
                devider *= 1000; // pasidarau didziausia skaiciu
                tripletIndex++; // pasirasau kiek trijuliu turiu 

            }

            if (number < devider)
            {
                do
                {
                    devider /= 1000;
                    tripletIndex--;

                    long numberStarts = number / devider;
                    long numberEnd = number % devider;

                    if (numberStarts > 0)
                    {
                        if (numberStarts == 1)
                        {
                            output += " " + singular[tripletIndex];
                        }
                        else
                        {
                            ChangeHundredsToText(numberStarts, ref output);
                            if (numberStarts % 10 == 0)
                            {
                                output += " " + plural2[tripletIndex];
                            }
                            else if (numberStarts % 10 == 1)
                            {
                                output += " " + singular[tripletIndex];


                            }
                            else
                            {
                                output += " " + plural1[tripletIndex];
                            }
                        }
                        output += " ";

                    }
                    number = numberEnd;


                } while (devider > 1000);

                if (number > 0)
                {
                    ChangeHundredsToText(number, ref output);
                }


            }
            else
            {
                Console.WriteLine("Skaicius yra per didelis");
            }

            return output;
        }

        static void ChangeHundredsToText(long number, ref string output)
        {
            if (number < 100)
            {
                ChangeTensToText(number, ref output);
            }
            else
            {
                long simtai = number / 100;
                long vienetai = number % 100;
                if (simtai > 0)
                {
                    if (simtai == 1)
                    {
                        output += "simtas";
                    }
                    else
                    {
                        ChangeTensToText(simtai, ref output);
                        output += " simtai";
                    }

                }

                if ( vienetai != 0)
                {
                    output += " ";
                    ChangeTensToText(vienetai, ref output);

                }

            }
        }

        static void ChangeTensToText(long number, ref string output)
        {
            if (number < 20)
            {
                ChangeTeensToText(number, ref output);
            }
            else
            {
                long desimtys = number / 10;
                long vienetai = number % 10;

                string[] tensNumbers = { "", "desimt", "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt" };

                if (desimtys > 9)
                {
                    output += "KLAIDA su" + number;
                }
                else
                {
                    output += tensNumbers[desimtys];
                }

                if (vienetai != 0)
                {
                    output += " ";
                    ChangeTeensToText(vienetai, ref output);
                }

            }
        }

        static void ChangeTeensToText(long number, ref string output)
        {

            string[] firstNumbers = { "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni", "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika" };

            if (number > 19)
            {
                output += "Klaida su skaiciumi " + number;
            }
            else
            {
                output += firstNumbers[number];
            }





        }

        static bool CheckIfGoodNumber(string dataToCheck)
        {
            if (dataToCheck == "")
            {
                return false; // nera ivedimo todel false grazinu
            }

            for (int i = 0; i < dataToCheck.Length; i++)
            {
                char ch = dataToCheck[i];

                if (ch != '0' && ch != '1' && ch != '2' && ch != '3' && ch != '4' && ch != '5' && ch != '6' && ch != '7' && ch != '8' && ch != '9')
                {
                    if (ch != '-' || i != 0)
                    {
                        return false; // jeigu pirmas indeksas nera nulis ir nera minusas falsa meta
                    }

                }

            }
            return true;
        }

        private static bool CheckIfNumberInRange(long fromNUmber, long toNumber, long checkNumber)
        {
            return checkNumber > fromNUmber && checkNumber < toNumber;
        }

    }
}
