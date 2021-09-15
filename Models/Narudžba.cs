using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Test_Kiki.Models
{
    public class Narudžba
    {   public int Id { get; set; }
       public int Proizvod_Id { get; set; }
        public Proizvod Proizvod { get; set; }


        public int Količina { get; set; }
        public int Narudžba_Id { get; set; }
    }
}
