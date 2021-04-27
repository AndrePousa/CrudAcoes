﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TarefaMvc.Models
{
    public class Acoes
    {
       

        public int Id { get; set; }
        public String Acao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int Tipo { get; set; }
        public DateTime Data_hora { get; set; }
        public String Observacao { get; set; }

    
        
    }
}      
