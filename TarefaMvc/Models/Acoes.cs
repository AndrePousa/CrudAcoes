using System;
using System.ComponentModel.DataAnnotations;

namespace TarefaMvc.Models
{
    public class Acoes 
    {
       

        public int Id { get; set; }
        [Display(Name = "Ação")]
        public string Acao { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public int Tipo { get; set; }
        [Display(Name = "Data/Hora")]
        public DateTime Data_hora { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; } 

         
    }
}      
