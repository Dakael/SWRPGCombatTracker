using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SWRPGCombatTracker.Models
{
    public class PlayerModel
    {
        [Required]
        public int Agility { get; set; }

        [Required]
        public int Brawn { get; set; }

        [Required]
        public string Career { get; set; }

        [Required]
        [Display(Name = "Character Name")]
        public string CharacterName { get; set; }

        [Required]
        [Display(Name = "Critical Injuries")]
        public int CriticalInjuries { get; set; }

        [Required]
        public int Cunning { get; set; }

        [Required]
        [Display(Name = "Current Strain")]
        public int CurrentStrain { get; set; }

        [Required]
        [Display(Name = "Current Wounds")]
        public int CurrentWounds { get; set; }

        [Required]
        public int CurrentXP { get; set; }

        [Required]
        public int Encumberance { get; set; }

        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Individual Obligation")]
        public List<IndividualObligations> individualObligations { get; set; }

        [Required]
        public int Intellect { get; set; }

        [Required]
        public int MaxEncumberance { get; set; }

        [Required]
        [Display(Name = "Melee Defense")]
        public int MeleeDefense { get; set; }

        public int Morality { get; set; }

        [Required]
        [Display(Name = "Party Obligation")]
        public List<PartyObligations> partyObligations { get; set; }

        [Required]
        public int Presence { get; set; }

        [Required]
        [Display(Name = "Ranged Defense")]
        public int RangedDefense { get; set; }

        [Required]
        [Display(Name = "Soak Value")]
        public int SoakValue { get; set; }

        public List<Specializations> Specialization { get; set; }

        [Required]
        public string Species { get; set; }

        [Required]
        [Display(Name = "Strain Threshold")]
        public int StrainThreshold { get; set; }

        [Required]
        public int TotalXP { get; set; }

        [Required]
        public int Willpower { get; set; }

        [Required]
        [Display(Name = "Wound Threshold")]
        public int WoundThreshold { get; set; }

        public class IndividualObligations
        {
            [Key]
            [Required]
            public int Id { get; set; }

            [Required]
            public string Obligation { get; set; }

            [Required]
            public int Value { get; set; }
        }

        public class PartyObligations
        {
            [Key]
            [Required]
            public int Id { get; set; }

            [Required]
            public string Obligation { get; set; }

            [Required]
            public int Value { get; set; }
        }

        public class Specializations
        {
            [Key]
            [Required]
            public int id { get; set; }

            [Required]
            public string Specialization { get; set; }
        }
    }
}