using System.Collections.Generic;

namespace Domain.Challenges
{
    public abstract class BaseClass
    {
        public IList<InputValue> Answerlist;
        public InputValue InputValue;
        public abstract IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues);
    }
}