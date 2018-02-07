using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GraGieldowa.Models
{
    public class UstawieniaGryModel
    {
        [Display(Name ="Ilość graczy: ")]
        [Range(1,10)]
        public int IloscGraczy { get; set; }
        [Display(Name = "Ilość grubasów: ")]
        [Range(1, 5)]
        public int IloscGrubasow { get; set; }
        [Display(Name = "Ilość akcji: ")]
        [Range(100,1000000)]
        public int IloscAkcji { get; set; }
        [Display(Name = "Ilość pieniędzy: ")]
        [Range(100, 1000000)]
        public decimal IloscPieniedzy { get; set; }
        [Display(Name = "Procent akcji u graczy: ")]
        [Range(1, 100)]
        public decimal ProcentAkcjiGracze { get; set; }
        [Display(Name = "Procent akcji u grubasów: ")]
        [Range(1, 100)]
        public decimal ProcentAkcjiGrubasy { get; set; }
        [Display(Name = "Procent pieniędzy u graczy: ")]
        [Range(1, 100)]
        public decimal ProcentPieniedzyGracze { get; set; }
        [Display(Name = "Procent pieniędzy u grubasów: ")]
        [Range(1, 100)]
        public decimal ProcentPieniendzyGrubasy { get; set; }
    }
}