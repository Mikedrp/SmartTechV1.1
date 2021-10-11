using System.ComponentModel.DataAnnotations;
using System;
namespace PracticaSemanaIV.Shared.Entity
{
    public class Movie
    {
        public int Id{get;set;}
        [Required(ErrorMessage ="El Campo {0} es requerido")]
        public string Name{get;set;}
        public string Sipnosis{get;set;}
        public string Poster{get;set;}
        [Required(ErrorMessage ="El Campo {0} es requerido") ]
        public DateTime Premier {get;set;}
        public string Treiler{get;set;}
        public string ShortName
        {
            get{
                if (string.IsNullOrWhiteSpace(Name))
                {
                    return null;
                } if (Name.Length > 60){
                    return Name.Substring(0,60) + "...";
                } else{
                    return Name;
                }
            }
        }
    }
}