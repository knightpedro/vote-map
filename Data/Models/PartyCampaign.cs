using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public class PartyCampaign : BaseModel
    {
        public int CandidateSeats { get; set; }
        public int CandidateVotes { get; set; }
        public int PartySeats { get; set; }
        public int PartyVotes { get; set; }
        public bool Registered { get; set; }
        public Election Election { get; set; }
        public string ElectionId { get; set; }
        public Party Party { get; set; }
        public string PartyId { get; set; }

        public List<BoothPartyResult> BoothResults { get; set; }
        public List<ElectoratePartyResult> ElectorateResults { get; set; }

        public int TotalSeats => CandidateSeats + PartySeats;
        public int TotalVotes => CandidateVotes + PartyVotes;
    }
}
