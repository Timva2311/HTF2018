using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Challenges
{
    public class Challenge_3: BaseClass
    {
        public override IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues) 
        {
            AtbashCipher atbash = new AtbashCipher();
            var input = inputValues.FirstOrDefault();
            InputValue.Data = atbash.Decode(input.Data);
            InputValue.Name = "decoded";
            Answerlist.Add(InputValue);
            return Answerlist;
        }
    }

    public class AtbashCipher
    {
        private string _plain = "abcdefghijklmnopqrstuvwxyz ";
        private string _cipher = "zyxwvutsrqponmlkjihgfedcba ";
        private readonly List<int> _indices = new List<int>();

        public string Decode(string input)
        {
            Splitter(input).ForEach(x => _indices.Add(_cipher.IndexOf(x)));
            return _indices.Aggregate("", (current, index) => current + _plain[index]);
        }

        private List<char> Splitter(string input)
        {
            return input.ToCharArray().ToList();
        }
    }
}
