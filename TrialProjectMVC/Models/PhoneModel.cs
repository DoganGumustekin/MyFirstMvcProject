using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrialProjectMVC.Models
{
    public class PhoneModel
    {
        public int PhoneId { get; set; }


        [Required(ErrorMessage ="Bu alanın doldurulması zorunludur.")]
        [DisplayName("Telefon Numarası")]
        [MaxLength(20)]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [DisplayName("Adres")]
        public string Address { get; set; }
    }
}
