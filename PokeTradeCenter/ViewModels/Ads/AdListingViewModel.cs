using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokeTradeCenter.ViewModels.Ads
{
    public class AdListingViewModel
    {
        public List<AdListItem> Ads { get; set; }
    }

    public class AdListItem
    {
        public string Pokemon { get; set; }
        public string Nature { get; set; }
        [Display(Name = "Attack")]
        public int Atk { get; set; }
        [Display(Name = "Spe. Attack")]
        public int SpeAtk { get; set; }
        [Display(Name = "Defense")]
        public int Def { get; set; }
        [Display(Name = "Spe. Defense")]
        public int SpeDef { get; set; }
        [Display(Name = "Speed")]
        public int Speed { get; set; }
        [Display(Name = "HP")]
        public int Hp { get; set; }
        [Display(Name = "Level")]
        public int Level { get; set; }
        [Display(Name = "Move #1")]
        public string Move1 { get; set; }
        [Display(Name = "Move #2")]
        public string Move2 { get; set; }
        [Display(Name = "Move #3")]
        public string Move3 { get; set; }
        [Display(Name = "Move #4")]
        public string Move4 { get; set; }
        [Display(Name = "Shiny")]
        public bool Shiny { get; set; }
        [Display(Name = "Published")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ReleaseDate { get; set; }
        public int ID { get; set; }
    }
}
