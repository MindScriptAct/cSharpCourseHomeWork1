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
            const int FROM_NUMBER = -999;
            const int TO_NUMBER = 999;



            Console.WriteLine("Hello\n");

            string inputClose = "";

            while (inputClose != " ")
            {
                // Duomenys

                string[] singleNumbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                string[] TeensNumbers = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifthteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" };
                string[] DoubleNumbers = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                string hundred = " Hundred";

                // Programa 

                Console.WriteLine("Type the number from {0} To {1}", FROM_NUMBER, TO_NUMBER);

                string stringInput = InputString();

                bool isItDigit = IsItnumber(stringInput);

                int convertedNumber = ConvertionToInt(stringInput, isItDigit);

                bool RangeOneIndex = GoodRange(convertedNumber, 9, -9);

                bool RangeTwoIndexUpTo19 = GoodRange(convertedNumber, 19, -19);

                bool RangeTwoIndexUpTo99 = GoodRange(convertedNumber, 99, -99);

                bool RangeThreeIndex = GoodRange(convertedNumber, 999, -999);

                char[] arrayOfStringInput = InputSeparateNumbers(stringInput, isItDigit);

                string numberZeroToNine = ChangeSingleIntsToWords(convertedNumber, RangeOneIndex, singleNumbers);

                string numberWithTwoIndexUpTo19 = ChangeTeensIntsToWords(arrayOfStringInput, RangeTwoIndexUpTo19, TeensNumbers);

                string numberWithTwoIndex = ChangeDoubleIntsToWords(convertedNumber, RangeTwoIndexUpTo99, singleNumbers, DoubleNumbers);

                string numberHundreds = ChangeHundredsIntToWords(convertedNumber, RangeThreeIndex, singleNumbers, TeensNumbers, DoubleNumbers, hundred);

                string negative = IsNumberNegative(convertedNumber, arrayOfStringInput);

                // Printing results: 

                Console.WriteLine($"Your digit: {convertedNumber}\nProgram result: {negative}{numberZeroToNine}{numberWithTwoIndexUpTo19}{numberWithTwoIndex}{numberHundreds}\n");

                Console.WriteLine("Press SPACE to exit the program \nOr press enter to Type another number");

                inputClose = Console.ReadLine();

            }

            Console.Clear();
            Console.WriteLine("Good Bye");
            Console.ReadKey();
        }

        // FUNCTIONS



        static string InputString()
        {
            string message;
            return message = Console.ReadLine();
        }

        static bool IsItnumber(string text)
        {
            bool result = false;
            string textTrimmed = text.Trim();

            for (int i = 0; i < textTrimmed.Length; i++)
            {
                if (char.IsDigit(textTrimmed[i]))
                {
                    result = true;
                }
            }
            return result;
        }

        static int ConvertionToInt(string text, bool isItNumber)
        {
            int result = 0;

            if (isItNumber)
            {
                result = Convert.ToInt32(text);
            }

            return result;

        }

        static bool GoodRange(int x, int max, int min)
        {
            if (x <= max && x >= min)
            {
                return true;
            }
            return false;
        }

        static char[] InputSeparateNumbers(string text, bool IsItDigits)
        {
            string error = "Input is not a Digit!";

            if (IsItDigits)
            {
                return text.ToCharArray();
            }
            else
            {
                return error.ToCharArray();
            }

        }

        static string IsNumberNegative(int x, char[] array)
        {
            if (x < 0 && array[0] == '-')
            {
                return "Minus ";
            }

            return "";

        }

        static string ChangeSingleIntsToWords(int x, bool rangeIsOkey, string[] arr)
        {
            string answer = "";

            if (rangeIsOkey)
            {

                switch (x)
                {
                    case 0:
                        answer = arr[0];
                        break;
                    case 1:
                    case -1:
                        answer = arr[1];
                        break;
                    case 2:
                    case -2:
                        answer = arr[2];
                        break;
                    case 3:
                    case -3:
                        answer = arr[3];
                        break;
                    case 4:
                    case -4:
                        answer = arr[4];
                        break;
                    case 5:
                    case -5:
                        answer = arr[5];
                        break;
                    case 6:
                    case -6:
                        answer = arr[6];
                        break;
                    case 7:
                    case -7:
                        answer = arr[7];
                        break;
                    case 8:
                    case -8:
                        answer = arr[8];
                        break;
                    case 9:
                    case -9:
                        answer = arr[9];
                        break;
                    default:
                        break;
                }

            }
            return answer;
        }

        static string ChangeTeensIntsToWords(char[] arr, bool rangeIsOkey, string[] arr2)
        {
            string answer = "";

            if (rangeIsOkey)
            {
                if (arr.Length >= 2)
                {

                    for (int i = 0; i < 1; i++)
                    {
                        if (arr.Length == 3)
                        {
                            i++;
                        }

                        if (arr[i] == '1' && arr[i + 1] == '0')
                        {
                            answer = arr2[0];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '1')
                        {
                            answer = arr2[1];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '2')
                        {
                            answer = arr2[2];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '3')
                        {
                            answer = arr2[3];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '4')
                        {
                            answer = arr2[4];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '5')
                        {
                            answer = arr2[5];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '6')
                        {
                            answer = arr2[6];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '7')
                        {
                            answer = arr2[7];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '8')
                        {
                            answer = arr2[8];
                        }
                        else if (arr[i] == '1' && arr[i + 1] == '9')
                        {
                            answer = arr2[9];
                        }
                        else
                        {
                            answer = "";
                        }

                    }

                }

            }
            return answer;
        }

        static string ChangeDoubleIntsToWords(int x, bool rangeIsOkey, string[] singles, string[] tys)
        {
            if (rangeIsOkey)
            {
                if (x > 19 && x < 100 || x < -19 && x > -100)
                {
                    int firstNumber = x / 10;
                    int secondNumber = x % 10;

                    string answer1 = "";
                    string answer2 = "";

                    switch (firstNumber)
                    {
                        case 2:
                        case -2:
                            answer1 = tys[0];
                            break;
                        case 3:
                        case -3:
                            answer1 = tys[1];
                            break;
                        case 4:
                        case -4:
                            answer1 = tys[2];
                            break;
                        case 5:
                        case -5:
                            answer1 = tys[3];
                            break;
                        case 6:
                        case -6:
                            answer1 = tys[4];
                            break;
                        case 7:
                        case -7:
                            answer1 = tys[5];
                            break;
                        case 8:
                        case -8:
                            answer1 = tys[6];
                            break;
                        case 9:
                        case -9:
                            answer1 = tys[7];
                            break;

                        default:
                            break;
                    }

                    switch (secondNumber)
                    {

                        case 1:
                        case -1:
                            answer2 = singles[1];
                            break;
                        case 2:
                        case -2:
                            answer2 = singles[2];
                            break;
                        case 3:
                        case -3:
                            answer2 = singles[3];
                            break;
                        case 4:
                        case -4:
                            answer2 = singles[4];
                            break;
                        case 5:
                        case -5:
                            answer2 = singles[5];
                            break;
                        case 6:
                        case -6:
                            answer2 = singles[6];
                            break;
                        case 7:
                        case -7:
                            answer2 = singles[7];
                            break;
                        case 8:
                        case -8:
                            answer2 = singles[8];
                            break;
                        case 9:
                        case -9:
                            answer2 = singles[9];
                            break;
                        default:
                            break;
                    }
                    string result = answer1 + " " + answer2;
                    return result;
                }

            }
            return "";
        }

        static string ChangeHundredsIntToWords(int x, bool rageIsOkey, string[] singles, string[] teens, string[] tys, string hundredText)
        {
            if (rageIsOkey)
            {
                if (x.ToString().Length == 3 || x.ToString().Length == 4)
                {
                    if (x.ToString().Length == 4)
                    {
                        x = x * -1;
                    }
                    int firstnumber = x / 100 % 10;
                    int secondNumber = x / 10 % 10;
                    int thirdNUmber = x % 10;

                    string hundredAnswer = "";
                    string teensAnswer = "";

                    string and = "";
                    string tysAnswer = "";
                    string singleNumberAnswer = "";

                    switch (firstnumber)
                    {
                        case 1:
                            hundredAnswer = singles[1] + hundredText;
                            break;
                        case 2:
                            hundredAnswer = singles[2] + hundredText;
                            break;
                        case 3:
                            hundredAnswer = singles[3] + hundredText;
                            break;
                        case 4:
                            hundredAnswer = singles[4] + hundredText;
                            break;
                        case 5:
                            hundredAnswer = singles[5] + hundredText;
                            break;
                        case 6:
                            hundredAnswer = singles[6] + hundredText;
                            break;
                        case 7:
                            hundredAnswer = singles[7] + hundredText;
                            break;
                        case 8:
                            hundredAnswer = singles[8] + hundredText;
                            break;
                        case 9:
                            hundredAnswer = singles[9] + hundredText;
                            break;
                        default:
                            break;
                    }
                    if (secondNumber == 1)
                    {
                        switch (thirdNUmber)
                        {
                            case 0:
                                teensAnswer = teens[0];
                                break;
                            case 1:
                                teensAnswer = teens[1];
                                break;
                            case 2:
                                teensAnswer = teens[2];
                                break;
                            case 3:
                                teensAnswer = teens[3];
                                break;
                            case 4:
                                teensAnswer = teens[4];
                                break;
                            case 5:
                                teensAnswer = teens[5];
                                break;
                            case 6:
                                teensAnswer = teens[6];
                                break;
                            case 7:
                                teensAnswer = teens[7];
                                break;
                            case 8:
                                teensAnswer = teens[8];
                                break;
                            case 9:
                                teensAnswer = teens[9];
                                break;
                            default:
                                break;
                        }
                    }
                    switch (secondNumber)
                    {
                        case 2:
                            tysAnswer = tys[0];
                            and = "and";
                            break;
                        case 3:
                            tysAnswer = tys[1];
                            and = "and";
                            break;
                        case 4:
                            tysAnswer = tys[2];
                            and = "and";
                            break;
                        case 5:
                            tysAnswer = tys[3];
                            and = "and";
                            break;
                        case 6:
                            tysAnswer = tys[4];
                            and = "and";
                            break;
                        case 7:
                            tysAnswer = tys[5];
                            and = "and";
                            break;
                        case 8:
                            tysAnswer = tys[6];
                            and = "and";
                            break;
                        case 9:
                            tysAnswer = tys[7];
                            and = "and";
                            break;
                        default:
                            break;
                    }
                    switch (thirdNUmber)
                    {
                        case 1:
                            singleNumberAnswer = singles[1];
                            break;
                        case 2:
                            singleNumberAnswer = singles[2];
                            break;
                        case 3:
                            singleNumberAnswer = singles[3];
                            break;
                        case 4:
                            singleNumberAnswer = singles[4];
                            break;
                        case 5:
                            singleNumberAnswer = singles[5];
                            break;
                        case 6:
                            singleNumberAnswer = singles[6];
                            break;
                        case 7:
                            singleNumberAnswer = singles[7];
                            break;
                        case 8:
                            singleNumberAnswer = singles[8];
                            break;
                        case 9:
                            singleNumberAnswer = singles[9];
                            break;
                        default:
                            break;
                    }
                    string result = hundredAnswer + " " + and + " " + teensAnswer + " " + tysAnswer + " " + singleNumberAnswer;
                    return result;
                }
            }
            return "";

        }




    }


}


