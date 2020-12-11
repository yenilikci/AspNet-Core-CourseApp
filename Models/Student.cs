using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email Adesinizi Giriniz")]
        [EmailAddress(ErrorMessage ="Email Adresinizi Düzgün Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Telefonunuzu Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Katılma Durumunuzu Seçiniz")]
        public bool? Confirm { get; set; } //true,false,null
    }
}
