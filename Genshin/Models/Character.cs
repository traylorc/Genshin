using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Genshin.Models
{
    public class Character
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Region { get; set; }
        [Required, StringLength(80)]
        public string Location { get; set; }
        [Required]
        public int Ranking { get; set; }
        [Required]
        public int WeaponId { get; set; }
        [Required]
        public int ElementId { get; set; }

        public virtual Weapon Weapon {get; set;}

        public virtual Element Element {get; set; }

        public Character() // default constructor 
        {

        }
    }
}
