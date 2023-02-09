using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RandomNumber.Models
{
    public class Kalkulacka
    {
        public Kalkulacka()
        {
            Operace = "+";
            MozneOperace = new List<SelectListItem>
        {
            new SelectListItem { Text = "Sečti", Value = "+", Selected = true },
            new SelectListItem { Text = "Odečti", Value = "-" },
            new SelectListItem { Text = "Vynásob", Value = "*" },
            new SelectListItem { Text = "Vyděl", Value = "/" }
        };
        }

        public void VypocitejVysledek()
        {
            Vysledek = Operace switch
            {
                "+" => PrvniCislo + DruheCislo,
                "-" => PrvniCislo - DruheCislo,
                "*" => PrvniCislo * DruheCislo,
                "/" => PrvniCislo / DruheCislo,
                _ => 0
            };
        }
        [Display(Name = "1. číslo")]
        [Range(1, 100, ErrorMessage = "Zadejte prosím číslo od 1 do 100.")]
        public int PrvniCislo { get; set; }

        [Range(1, 100, ErrorMessage = "Zadejte prosím číslo od 1 do 100.")]
        [Display(Name = "2. číslo")]
        public int DruheCislo { get; set; }
        public double Vysledek { get; private set; }
        public string Operace { get; set; }

        [Display(Name = "2. číslo")]
        public List<SelectListItem> MozneOperace { get; private set; }


        
    }
}
