using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public class CandidateCampaign : BaseModel
    {
        public string CandidateId { get; set; } = null!;
        public Candidate Candidate { get; set; }
        public string ElectionId { get; set; }
        public Election Election { get; set; }
        public string PartyId { get; set; }
        public Party Party { get; set; }

        public ElectorateCandidateResult Result { get; set; }
        public List<BoothCandidateResult> BoothResults { get; set; }
    }
}
