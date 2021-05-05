using System;
using System.ComponentModel.DataAnnotations;

namespace TarefaMvc.Models
{
    public class Acoes 
    {
             
        public int Id { get; set; }

        [Display(Name = "Ação")]
        [Required(ErrorMessage = "{0} obrigatória")]
        public string Acao { get; set; } 
         
        [Required(ErrorMessage = "{0} obrigatória" )]
        public int Quantidade { get; set; }
      
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "{0} Obrigatório")]
        public decimal Preco { get; set; }
       
        public int Tipo { get; set; }
        [Display(Name = "Data/Hora")]
        [Required(ErrorMessage = "Data/Hora São obrigatórios")]
        public DateTime Data_hora { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; } 

                
    }
}      
