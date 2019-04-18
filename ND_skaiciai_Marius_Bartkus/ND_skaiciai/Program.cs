using System;

namespace ND_skaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių nuo -999999 iki 999999: \n");
            string initial_input;
            initial_input = Console.ReadLine();
       
                
                
            if (checkIfCorrect(initial_input)==true )
            {
                int inputas = Convert.ToInt32(initial_input);

                if (inputas > 0)
                { }
                else
                {
                    inputas = inputas * (-1);
                    Console.Write("Minus ");
                }

                int digitCount = countDigits(inputas);

                if (digitCount == 6)
                {
                    if (ret_6_digit(inputas) > 1)
                    {
                        Console.Write(retVienetai(ret_6_digit(inputas)) + " šimtai ");
                    }
                    else if (ret_3_digit(inputas) == 1)
                    {
                        Console.Write(" šimtas ");
                    }

                    else { }
                    if (ret_5_digit(inputas) > 1)
                    {
                        Console.Write(ret_desimtys(ret_5_digit(inputas)));
                        Console.Write(" " + retVienetai(ret_4_digit(inputas)));
                    }
                    else if (ret_5_digit(inputas) == 1)
                    {
                        Console.Write(retN_iolika(ret_4_digit(inputas)));
                    }
                    else
                    {
                        Console.Write(" " + retVienetai(ret_4_digit(inputas)));
                    }
                    if (ret_4_digit(inputas) == 0)
                    {

                        Console.Write(" tūkstančių ");
                    }
                    else
                    {
                        Console.Write(" tūkstančiai ");
                    }
                    if (ret_3_digit(inputas) > 1)
                    {
                        Console.Write(retVienetai(ret_3_digit(inputas)) + " šimtai ");
                    }
                    else if (ret_3_digit(inputas) == 1)
                    {
                        Console.Write(" šimtas ");
                    }
                    else { }
                    if (ret_2_digit(inputas) > 1)
                    {
                        Console.Write(ret_desimtys(ret_2_digit(inputas)));
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }
                    else if (ret_2_digit(inputas) == 1)
                    {
                        Console.Write(retN_iolika(ret_1_digit(inputas)));
                    }
                    else
                    {
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }









                }
                if (digitCount == 5)
                {
                    if (ret_5_digit(inputas) > 1)
                    {
                        Console.Write(ret_desimtys(ret_5_digit(inputas)));
                        Console.Write(" " + retVienetai(ret_4_digit(inputas)));
                        if (ret_4_digit(inputas) == 0)
                        {

                            Console.Write(" tūkstančių ");
                        }
                        else
                        {
                            Console.Write(" tūkstančiai ");
                        }
                    }
                    else
                    {
                        Console.Write(retN_iolika(ret_4_digit(inputas)) + " tūkstančių ");
                    }



                    if (ret_3_digit(inputas) > 1)
                    {
                        Console.Write(retVienetai(ret_3_digit(inputas)) + " šimtai ");
                    }
                    else if (ret_3_digit(inputas) == 1)
                    {
                        Console.Write(" šimtas ");
                    }
                    else { }
                    if (ret_2_digit(inputas) > 1)
                    {
                        Console.Write(ret_desimtys(ret_2_digit(inputas)));
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }
                    else if (ret_2_digit(inputas) == 1)
                    {
                        Console.Write(retN_iolika(ret_1_digit(inputas)));
                    }
                    else
                    {
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }
                }
                if (digitCount == 4)//jeigu penkiazenklis
                {

                    if (ret_4_digit(inputas) > 1)
                    {
                        Console.Write(retVienetai(ret_4_digit(inputas)) + " tūkstančiai ");
                    }
                    else if (ret_4_digit(inputas) == 1)
                    {
                        Console.Write(" tūkstantis ");
                    }
                    else { }
                    if (ret_3_digit(inputas) > 1)
                    {
                        Console.Write(retVienetai(ret_3_digit(inputas)) + " šimtai ");
                    }
                    else if (ret_3_digit(inputas) == 1)
                    {
                        Console.Write(" šimtas ");
                    }
                    else { }
                    if (ret_2_digit(inputas) > 1)
                    {
                        Console.Write(ret_desimtys(ret_2_digit(inputas)));
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }
                    else if (ret_2_digit(inputas) == 1)
                    {
                        Console.Write(retN_iolika(ret_1_digit(inputas)));
                    }
                    else
                    {
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }

                }
                if (digitCount == 3)
                {
                    if (ret_3_digit(inputas) > 1)
                    {
                        Console.Write(retVienetai(ret_3_digit(inputas)) + " šimtai ");
                    }
                    else if (ret_3_digit(inputas) == 1)
                    {
                        Console.Write(" šimtas ");
                    }
                    else { }
                    if (ret_2_digit(inputas) > 1)
                    {
                        Console.Write(ret_desimtys(ret_2_digit(inputas)));
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }
                    else if (ret_2_digit(inputas) == 1)
                    {
                        Console.Write(retN_iolika(ret_1_digit(inputas)));
                    }
                    else
                    {
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }

                }
                if (digitCount == 2)
                {

                    if (ret_2_digit(inputas) > 1)
                    {
                        Console.Write(ret_desimtys(ret_2_digit(inputas)));
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }
                    else if (ret_2_digit(inputas) == 1)
                    {
                        Console.Write(retN_iolika(ret_1_digit(inputas)));
                    }
                    else
                    {
                        Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                    }
                }
                if (digitCount == 1)
                {
                    Console.Write(" " + retVienetai(ret_1_digit(inputas)));
                }
            }
            else { Console.WriteLine("Neteisingai įvestas skaičius"); }
        }

            static bool checkIfCorrect(string a)
        {

            try
            {
                 Convert.ToInt32(a);
                    return true ;
            }


            catch (Exception)
            {
                return false;
            }
        }
            static int countDigits(int input)
            
{
                int digitNum = 0;
                int tempnum = input;
                for (int i = 1; tempnum >= 1; i++)
                {
                    tempnum = tempnum / 10;
                    digitNum = i;
                }

                return digitNum;
                // return digitNum;
            }

             static int ret_6_digit(int input)
            {
                input = (input / 100000) % 10;
                return input;
            }
            static int ret_5_digit(int input)
            {
                input = (input / 10000) % 10;
                return input;
            }
            static int ret_4_digit(int input)
            {
                input = (input / 1000) % 10;
                return input;
            }

            static int ret_3_digit(int input)
            {
                input = (input / 100) % 10;
                return input;
            }
            static int ret_2_digit(int input)
            {
                input = (input / 10) % 10;
                return input;
            }
            static int ret_1_digit(int input)
            {
                input = (input) % 10;
                return input;
            }

            static string retVienetai(int inputas)
            {

                if (inputas == 9)
                {

                    return "devyni";
                }
                else if (inputas == 8)
                {

                    return "aštuoni";
                }
                else if (inputas == 7)
                {

                    return "septyni";
                }
                else if (inputas == 6)
                {

                    return "šeši";
                }
                else if (inputas == 5)
                {

                    return "penki";
                }
                else if (inputas == 4)
                {

                    return "keturi";
                }
                else if (inputas == 3)
                {

                    return "trys";
                }
                else if (inputas == 2)
                {

                    return "du";
                }
                else if (inputas == 1)
                {

                    return "vienas";
                }
                else
                {

                    return "";
                }


            }

            static string retN_iolika(int inputas)
            {

                if (inputas == 9)
                {

                    return "devyniolika";
                }
                else if (inputas == 8)
                {

                    return "aštuoniolika";
                }
                else if (inputas == 7)
                {

                    return "septyniolika";
                }
                else if (inputas == 6)
                {

                    return "šešiolika";
                }
                else if (inputas == 6)
                {

                    return "penkiolika";
                }
                else if (inputas == 4)
                {

                    return "keturiolika";
                }
                else if (inputas == 3)
                {

                    return "trylika";
                }
                else if (inputas == 2)
                {

                    return "dvylika";
                }
                else if (inputas == 1)
                {

                    return "vienuolika";
                }
                else { return "dešimt"; }
            }
            static string ret_desimtys(int inputas)
            {

                if (inputas == 9)
                {

                    return "devyniasdešimt";
                }
                else if (inputas == 8)
                {

                    return "aštuoniasdešimt";
                }
                else if (inputas == 7)
                {

                    return "septyniasdešimt";
                }
                else if (inputas == 6)
                {

                    return "šešiasdešimt";
                }
                else if (inputas == 5)
                {

                    return "penkiasdešimt";
                }
                else if (inputas == 4)
                {

                    return "keturiasdešimt";
                }
                else if (inputas == 3)
                {

                    return "trisdešimt";
                }
                else if (inputas == 2)
                {

                    return "dvidešimt";
                }
                else return " ";
            }


        }

    }

    




    

    
  