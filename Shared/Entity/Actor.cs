using System.ComponentModel.DataAnnotations;
using System;
namespace PracticaSemanaIV.Shared.Entity
{
    public class Actor
    {
      public int Id{get;set;}
      [Required (ErrorMessage="El campo {0} es requerido")]
      public string Name{get;set;} 
      [Required (ErrorMessage="El campo {0} es requerido")]
      public DateTime? BirthDate{get;set;}
      public string Photo{get;set;}
      public int KnowCredits{get;set;}
      public string Biography{get;set;}
      public string Nominations{get;set;}    
      
     

    }

   
}