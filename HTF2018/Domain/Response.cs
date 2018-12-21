using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Response
    {
        public string Identifier { get; set; }
        public string Status { get; set; }
        public string Identification { get; set; }
        public Dictionary<string, ChallengeStatus> Overview { get; set; }
    }
}
