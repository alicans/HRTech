using ApplicationCore.Enums;
using System.ComponentModel.DataAnnotations;

namespace IdentityDenemeHRTech.Models
{
    public class YeniAvansViewModel
    {
        [Required(ErrorMessage = "Lütfen alanı doldurunuz!")]
        [Range(0, double.MaxValue, ErrorMessage = "Tutar 0'dan küçük olamaz.")]
        public decimal Tutar { get; set; }

        [Required(ErrorMessage = "Lütfen alanı doldurunuz!")]
        public DateTime Tarih { get; set; }

        [Required(ErrorMessage = "Lütfen alanı doldurunuz!")]
        [MaxLength(300, ErrorMessage = "Açıklama 300 karakterden fazla olamaz!")]
        public string Aciklama { get; set; } = null!;
        public AvansTuru Tur { get; set; }
        public AvansDurumu Durum { get; set; }
    }
}
