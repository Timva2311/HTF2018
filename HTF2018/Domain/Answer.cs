using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Answer
    {
        public string ChallengeId { get; set; }
        public List<InputValue> Values { get; set; }
    }
}
