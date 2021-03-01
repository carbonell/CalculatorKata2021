using System;
using System.Collections.Generic;

namespace Ramona_New_Proyect
{
    public class StringCalculator
    {

        public int Add(string numbers)
        {
            if (numbers == "")
                return 0;


            char delimiter = ' ';
            if (numbers.Contains("//"))
            {
                delimiter = numbers[2];
            }
            else
            {
                delimiter = ',';
            }

            string delimiteTs = delimiter.ToString();
            var replaceline = numbers.Replace("//", delimiteTs).Replace("\n", delimiteTs);
            var separatedNumbers = replaceline.Split(delimiter);

            int resultOutline = SumArrayValues(separatedNumbers);
            return resultOutline;

        }

        private int SumArrayValues(string[] separatedNumbers)
        {

            int resultOutline = 0;

            var negativeNumbers = "";
            for (int i = 0; i < separatedNumbers.Length; i++)
            {
                if (separatedNumbers[i] == "")
                {
                }
                else
                {

                    var number = Convert.ToInt32(separatedNumbers[i]);
                    if (number < 0)
                    {
                        negativeNumbers = negativeNumbers + number + ",";
                    }

                    resultOutline = number + resultOutline;
                }
            }


            if (negativeNumbers != "")
            {
                negativeNumbers = negativeNumbers.Substring(0, negativeNumbers.Length - 1);
                throw new InvalidOperationException("negative not allowed: " + negativeNumbers);
            }

            return resultOutline;
        }


    }



}
