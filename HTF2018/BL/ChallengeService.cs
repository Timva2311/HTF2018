using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Domain;
using Domain.Challenges;

namespace BL
{
    public class ChallengeService
    {
        private readonly HackTheFutureApi _api;
        public ChallengeService(HackTheFutureApi api)
        {
            _api = api;
        }

        public Dictionary<string, ChallengeStatus> GetAllStates()
        {
            return _api.GetChallengeCodes().Overview;
        }

        public void ExecuteAllChallenges()
        {
            var codes = _api.GetChallengeCodes().Overview.Values.Select(v => v.Entry.Substring(38));
            
        }

        private BaseClass GetChallenge(int x)
        {
            switch (x)
            {
                case 2:
                     return new Challenge_2();
                case 3: 
                    return new Challenge_3();
                case 4:
                    return new Challenge_4();
                case 6:
                    return new Challenge_6();
                case 7:
                    return new Challenge_7();
                default:
                    return null;
            }
        }
    }
}
