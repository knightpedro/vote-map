using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public enum ElectorateType
    {
        General,
        Maori
    }

    public class Electorate : BaseModel
    {
        public string Name { get; set; }
        public ElectorateType Type { get; set; }

        public List<BoothVote> BoothVotes { get; set; }
        public List<ElectorateVote> ElectorateVotes { get; set; }
        public List<ElectoratePartyResult> PartyResults { get; set; }
    }
}
