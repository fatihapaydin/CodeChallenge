using System;

namespace App.Models
{
    class AB
    {
        public string FillWithSameCharacter(string fillingString, int countOfCharacter, string character)
        {
            if (countOfCharacter == 0)
                return fillingString;

            for (int i = 0; i < countOfCharacter; i++)
            {
                fillingString += character;
            }

            return fillingString;
        }

        public string createString(int N, int K)
        {

            if (K > N * (N - 1) / 2)
            {
                return "";
            }

            if (K == 0)
                return FillWithSameCharacter("", N - 1, "B") + "A";

            if (K == 1)
                return FillWithSameCharacter("", N - 2, "B") + "AB";


            int countOfLeadingA = 0;
            int countOfB = 0;
            int countOfLastA = 0;

            for (int j = 2; j < K; j++)
            {
                if (K % j == 0)
                {
                    var quotient = K / j;

                    if (j + quotient <= N)
                    {
                        countOfLeadingA = Math.Min(quotient, j);
                        countOfB = Math.Max(quotient, j);
                        countOfLastA = N - j - quotient;
                        break;
                    }
                }
            }

            string result = "";

            result = FillWithSameCharacter(result, countOfLeadingA, "A");
            result = FillWithSameCharacter(result, countOfB, "B");
            result = FillWithSameCharacter(result, countOfLastA, "A");


            return result;
        }
    }

}