using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Test_Kiki.Models
{
    public class Proizvod
    {
      
        public int Id { get; set; }

        [Required ,MaxLength (30)]
        public string Naziv_Proizvoda { get; set; }

        public float Cijena { get; set; }

        [MaxLength(255)]
        public string Link_Slika { get; set; }
    }
}
