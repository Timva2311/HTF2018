using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Challenges
{
    public class Challenge_3: BaseClass
    {
        public IEnumerable<InputValue> Challenge3(IEnumerable<InputValue> inputValues) 
        {
            AtbashCipher atbash = new AtbashCipher();
            var input = inputValues.FirstOrDefault();
            inputValue.data = atbash.Decode(input.data);
            inputValue.name = "decoded";
            answerlist.Add(inputValue);
            return answerlist;
        }
    }

    public class AtbashCipher
    {
        private string _plain = "abcdefghijklmnopqrstuvwxyz";
        private string _cipher = "zyxwvutsrqponmlkjihgfedcba";
        private readonly string _input;
        private readonly List<int> _indices = new List<int>();

        public string Encode(string input)
        {
            Splitter(_input).ForEach(x => _indices.Add(_plain.IndexOf(x)));
            return _indices.Aggregate("", (current, index) => current + _cipher[index]);
        }

        public string Decode(string input)
        {
            Splitter(_input).ForEach(x => _indices.Add(_cipher.IndexOf(x)));
            return _indices.Aggregate("", (current, index) => current + _plain[index]);
        }

        private List<char> Splitter(string input)
        {
            return input.ToCharArray().ToList();
        }
    }
}
