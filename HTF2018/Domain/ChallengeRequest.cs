using System;

namespace Domain
{
    public class ChallengeRequest
    {
            public string Id { get; set; }
            public string Identifier { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public Question Question { get; set; }

    }
}
