namespace VoteMap.Data.Models
{
    public class ElectorateVote : BaseModel
    {
        public int Enrolled { get; set; }
        public int Population { get; set; }

        public int CandidateValidOrdinaryVotes { get; set; }
        public int CandidateInformalOrdinaryVotes { get; set; }
        public int CandidateValidSpecialVotes { get; set; }
        public int CandidateInformalSpecialVotes { get; set; }
        public int CandidateSpecialVotesDisallowed { get; set; }

        public int PartyValidOrdinaryVotes { get; set; }
        public int PartyInformalOrdinaryVotes { get; set; }
        public int PartyValidSpecialVotes { get; set; }
        public int PartyInformalSpecialVotes { get; set; }
        public int PartySpecialVotesDisallowed { get; set; }

        public string ElectionId { get; set; }
        public Election Election { get; set; }
        public string ElectorateId { get; set; }
        public Electorate Electorate { get; set; }

        public int CandidateValidVotes => CandidateValidOrdinaryVotes + CandidateValidSpecialVotes;
        public int CandidateInformalVotes => CandidateInformalOrdinaryVotes + CandidateInformalSpecialVotes;
        public int CandidateTotalVotes => CandidateValidVotes + CandidateInformalVotes + CandidateSpecialVotesDisallowed;
        public decimal CandidateVoterTurnout => Enrolled > 0 ? CandidateTotalVotes / Enrolled : 0;

        public int PartyValidVotes => PartyValidOrdinaryVotes + PartyValidSpecialVotes;
        public int PartyInformalVotes => PartyInformalOrdinaryVotes + PartyInformalSpecialVotes;
        public int PartyTotalVotes => PartyValidVotes + PartyInformalVotes + PartySpecialVotesDisallowed;
        public decimal PartyVoterTurnout => Enrolled > 0 ? PartyTotalVotes / Enrolled : 0;
    }
}
