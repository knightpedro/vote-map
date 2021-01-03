using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public class Booth : BaseModel
    {
        public string Name { get; set; }
        public string Suburb { get; set; }
        public Point Location { get; set; }
        public List<BoothVote> BoothVotes { get; set; }
        public List<BoothCandidateResult> CandidateResults { get; set; }
        public List<BoothPartyResult> PartyResults { get; set; }
    }
}
