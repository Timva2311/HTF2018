using System;

namespace Domain
{
    public class ChallengeRequest
    {
            public string id { get; set; }
            public string identifier { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public Question question { get; set; }

    }
}
