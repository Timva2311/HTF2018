using System.Collections.Generic;
using System.Linq;

namespace Domain.Challenges
{
    public class Challenge_4 : BaseClass
    {
        public string Challenge4(IEnumerable<InputValue> inputValues)
        {
            AtbashCipher atbash = new AtbashCipher();
            var input = inputValues.FirstOrDefault();
            return atbash.Decode(input.Data);
        }
    }

    public class CalculatePrimeNumbers: BaseClass
    {
        public IEnumerable<InputValue> CalculatePrimes(int begin, int end)
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
                    InputValue.Data = num.ToString();
                    InputValue.Name = "prime";
                    Answerlist.Add(InputValue);
                }
            }
            return Answerlist;
        }
    }
}
