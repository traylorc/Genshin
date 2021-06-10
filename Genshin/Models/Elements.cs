using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Genshin.Models
{
    public class Elements
    {

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Element { get; set; }







        public Elements() { }
    }
}
