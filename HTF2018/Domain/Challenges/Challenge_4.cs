using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Challenges
{
    public class Challenge_4: BaseClass
    {
        public IEnumerable<InputValue> Challenge4(IEnumerable<InputValue> inputValues)
        {
            AtbashCipher atbash = new AtbashCipher();
            CalculatePrimeNumbers calculate = new CalculatePrimeNumbers();
            int start = 0;
            int end = 0;
            foreach (var i in inputValues)
            {
                switch (i.Name)
                {
                    case "start":
                        start = Int32.Parse(i.Data);
                        break;
                    case "end":
                        end = Int32.Parse(i.Data);
                        break;
                }
            }
            InputValue.Data = (calculate.CalculatePrimes(start, end)).ToString();
            InputValue.Name = "prime";
            Answerlist.Add(InputValue);
            return Answerlist;
        }
    }

    public class CalculatePrimeNumbers: BaseClass
    {
        public int CalculatePrimes(int begin, int end)
        {
            for (int num = begin; num <= end; num++)
            {
                var ctr = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                {
                    return num;
                }
            }
            return 0;
        }
    }
}
