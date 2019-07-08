using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberToWords
{
    class Program
    {

        const int FROM_NUMBER = -9;
        const int TO_NUMBER = 9;


        static void Main()
        {
            // TODO : keiskite FROM..TO skaicius pagal tai kiek spesite padaryt uzduociu. (-19...19, -99..99, ir tt.)

        
            Console.WriteLine("Sveiki!");   
            
            Console.WriteLine($"Iveskite skaiciu nuo {FROM_NUMBER} iki {TO_NUMBER}.   (Iveskite Space programai uzbaigti.)");

            string numberInput = Console.ReadLine();          
            

            ChangeNumberToText(numberInput);
            

            Console.ReadKey();





        }


      
       




        public static string ChangeNumberToText(string numberInput)
        {
            
            

            if (CheckIfGoodNumber(numberInput))
            {
                CheckIfNumberInRange(numberInput);
                ChangeOnesToString(numberInput);
            }
            else
            {
                Console.WriteLine("Bandykite dar karta");
                               
            }
            return numberInput;

            
        }
        public static bool CheckIfGoodNumber(string numberInput)
        {

            int retNum;

            bool number = int.TryParse(numberInput, out retNum);
            if (number)
            {
                Console.WriteLine("Jus ivedete " + number);
                
            }
            else
            {
                
                Console.WriteLine("Jusu ivedete ne skaiciu");
              
            }
            return number;


        }

      
        public static int CheckIfNumberInRange(string numberInput)
        {
           
            int CheckNumber = int.Parse(numberInput);          
            




            if (CheckNumber >= FROM_NUMBER && CheckNumber <= TO_NUMBER)
            {
                Console.WriteLine("Jusu ivestas skaicius tinkamas");
                   
                return CheckNumber;

            }

            else
            {
                Console.WriteLine("Jusu ivestas skaicius  netinkamas");
                return 0;

            }

        }
        public static string ChangeOnesToString(String num01)
        {
            int _Num01 = Convert.ToInt32(num01);
            String name = "";
            switch (_Num01)
            {
                case 0:
                    name = "nulis";
                    break;
                case 1:
                    name = "vienas";
                    break;
                case 2:
                    name = "du";
                    break;
                case 3:
                    name = "trys";
                    break;
                case 4:
                    name = "keturi";
                    break;
                case 5:
                    name = "penki";
                    break;
                case 6:
                    name = "sesi";
                    break;
                case 7:
                    name = "septyni";
                    break;
                case 8:
                    name = "astuoni";
                    break;
                case 9:
                    name = "devyni";
                    break;
            }
            Console.WriteLine("Jusu ivestas skaicius " + name);
            return name;
        }
        private
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
 
 