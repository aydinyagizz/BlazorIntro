using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIntro.Models
{
    public class ProductAddModel
    {
        [Required(ErrorMessage = "Ürün adını giriniz.")]
        [StringLength(20, ErrorMessage = "Ürün adını en fazla 20 karakter olmalıdır.")]
        public string ProductName { get; set; }
         
        [Required(ErrorMessage = "Ürün açıklamasını giriniz.")]
        [StringLength(40, ErrorMessage = "Ürün açıklaması en fazla 40 karakter olmalıdır.")]
        public string Description { get; set; }

        //ürün hangi kategoride 
        [Required(ErrorMessage = "Ürün kategorisini giriniz.")]
        public string CategoryId { get; set; }
    }
}
