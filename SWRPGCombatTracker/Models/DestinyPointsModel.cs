using System.ComponentModel.DataAnnotations;

namespace SWRPGCombatTracker.Models
{
    public class DestinyPointsModel
    {
        [Required]
        public int Dark { get; set; }

        //This table will only ever have one record... lol
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public int Light { get; set; }
    }
}