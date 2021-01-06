using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public class CandidateCampaign : BaseModel
    {
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public int ElectionId { get; set; }
        public Election Election { get; set; }
        public int? PartyId { get; set; }
        public Party Party { get; set; }

        public ElectorateCandidateResult Result { get; set; }
        public List<BoothCandidateResult> BoothResults { get; set; }
    }
}
