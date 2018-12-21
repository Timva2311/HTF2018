using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Answer
    {
        public string challengeId { get; set; }
        public List<InputValue> values { get; set; }
    }
}
