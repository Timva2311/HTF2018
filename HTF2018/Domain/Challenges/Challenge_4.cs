using System.Collections.Generic;
using System.Linq;

namespace Domain.Challenges
{
    public class Challenge_4
    {
        public string Challenge4(IEnumerable<InputValue> inputValues)
        {
            AtbashCipher atbash = new AtbashCipher();
            var input = inputValues.FirstOrDefault();
            return atbash.Decode(input.data);
        }
    }

    public class CalculatePrimeNumbers: BaseClass
    {
        public IEnumerable<InputValue> CalculatePrimes(int begin, int end)
        {
            for (int num = begin; num <= end; num++)
            {
                var ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                {
                    inputValue.data = num.ToString();
                    inputValue.name = "prime";
                    answerlist.Add(inputValue);
                }
            }
            return answerlist;
        }
    }
}
