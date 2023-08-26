using System.ComponentModel;

namespace TrialProjectMVC.Models
{
    public class PhoneModel
    {
        public int PhoneId { get; set; }
        [DisplayName("Telefon Numarası")]
        public string Phone { get; set; }
        [DisplayName("Adres")]
        public string Address { get; set; }
    }
}
