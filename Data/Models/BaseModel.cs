using System.ComponentModel.DataAnnotations.Schema;

namespace VoteMap.Data.Models
{
    public abstract class BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
    }
}
