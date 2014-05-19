using System;

namespace Homework_5
{
    class NumberToWord
    {
        static void Main()
        {
            Console.Write("Input your number [0..999]: ");
            string num = Console.ReadLine();
            int length = num.Length;
            int ones = 0;
            int tens = 0;
            int hundreds = 0;
            if (length == 3)
            {
                ones = int.Parse(num[2].ToString());
                tens = int.Parse(num[1].ToString());
                hundreds = int.Parse(num[0].ToString());
            }
            else if (length == 2)
            {
                ones = int.Parse(num[1].ToString());
                tens = int.Parse(num[0].ToString());
            }
            else if (length == 1)
            {
                ones = int.Parse(num[0].ToString());                
            }

            string english = "";
            string and = "";
            if (hundreds > 0)
            {
                and = "and ";
            }

            switch (hundreds)
            {
                case 1:
                    english = english + "One hundred " + and;
                    break;
                case 2:
                    english = english + "Two hundred " + and;
                    break;
                case 3:
                    english = english + "Three hundred " + and;
                    break;
                case 4:
                    english = english + "Four hundred " + and;
                    break;
                case 5:
                    english = english + "Five hundred " + and;
                    break;
                case 6:
                    english = english + "Six hundred " + and;
                    break;
                case 7:
                    english = english + "Seven hundred " + and;
                    break;
                case 8:
                    english = english + "Eight hundred " + and;
                    break;
                case 9:
                    english = english + "Nine hundred " + and;
                    break;
                default:
                    break;
            }
            switch (tens)
            {
                case 1:
                        switch (ones)
                        {
                            case 1:
                                english = english + "Eleven";
                                break;
                            case 2:
                                english = english + "Twelve";
                                break;
                            case 3:
                                english = english + "Thirteen";
                                break;
                            case 4:
                                english = english + "Fourteen";
                                break;
                            case 5:
                                english = english + "Fifteen";
                                break;
                            case 6:
                                english = english + "Sixteen";
                                break;
                            case 7:
                                english = english + "Seventeen";
                                break;
                            case 8:
                                english = english + "Eighteen";
                                break;
                            case 9:
                                english = english + "Nineteen";
                                break;
                            default:
                                break;
                        }
                        ones = 0;
                    break;
                case 2:
                    if (ones == 0)
                    {
                        english = english + "Twelve";
                    }
                    else
                    {
                        english = english + "Twenty" + " ";
                    }
                    break;
                case 3:
                    english = english + "Thirty" + " ";
                    break;
                case 4:
                    english = english + "Forty" + " ";
                    break;
                case 5:
                    english = english + "Fifty" + " ";
                    break;
                case 6:
                    english = english + "Sixty" + " ";
                    break;
                case 7:
                    english = english + "Seventy" + " ";
                    break;
                case 8:
                    english = english + "Eighty" + " ";
                    break;
                case 9:
                    english = english + "Ninety" + " ";
                    break;
                default:
                    break;
            }
            switch (ones)
            {
                case 1:
                    english = english + "One";
                    break;
                case 2:
                    english = english + "Two" ;
                    break;
                case 3:
                    english = english + "Three";
                    break;
                case 4:
                    english = english + "Four";
                    break;
                case 5:
                    english = english + "Five";
                    break;
                case 6:
                    english = english + "Six";
                    break;
                case 7:
                    english = english + "Seven";
                    break;
                case 8:
                    english = english + "Eight";
                    break;
                case 9:
                    english = english + "Nine";
                    break;
                default:
                    break;
            }
            if (int.Parse(num) == 0)
            {
                Console.WriteLine("Zero");             
            }
            Console.WriteLine(english);
        }
    }
}
