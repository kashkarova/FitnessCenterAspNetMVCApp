using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessCenterAspNetMVCApp.Models
{
    public class AddNewAbonementModel
    {
        [Key]
        public int key { get; set; }

        [Required]
        [Display(Name ="Фамилия")]
        public string c_surname { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string c_name { get; set; }

        [Required]
        [Display(Name = "Номер телефона")]
        public string c_phone { get; set; }

        [Required]
        [Display(Name = "Услуга")]
        public string s_title { get; set; }

        [Required]
        [Display(Name = "Количество посещений")]
        public int a_count { get; set; }

        [Required]
        [Display(Name = "Дата начала действия абонемента")]
        public DateTime date_begin { get; set; }

        [Required]
        [Display(Name = "Дата окончания действия абонемента")]
        public DateTime date_end { get; set; }

        public AddNewAbonementModel()
        {
            Random rnd = new Random();
            key = rnd.Next(1, 5000000);
        }
        
    }
}