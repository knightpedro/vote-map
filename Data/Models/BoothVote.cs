namespace VoteMap.Data.Models
{
    public class BoothVote : BaseModel
    {
        public int CandidateValidVotes { get; set; }
        public int CandidateInformalVotes { get; set; }
        public int PartyValidVotes { get; set; }
        public int PartyInformalVotes { get; set; }

        public int BoothId { get; set; }
        public Booth Booth { get; set; }
        public int ElectorateId { get; set; }
        public Electorate Electorate { get; set; }
        public int ElectionId { get; set; }
        public Election Election { get; set; }
    }
}
