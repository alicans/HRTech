using ApplicationCore.Attributes.Personel;
using System.ComponentModel.DataAnnotations;

namespace IdentityDenemeHRTech.Models
{
    public class ChangePasswordViewModel
    {
        public string EskiSifre { get; set; } = null!;

        [Sifre(ErrorMessage = "Şifre en az 8 karakter uzunluğunda olmalı, en az bir rakam ve en az bir büyük harf içermelidir.")]
        [SifreKarsilastirma("EskiSifre")]
        public string Sifre { get; set; } = null!;

        [Compare("Sifre",ErrorMessage = "Şifreler aynı değil!")]
        public string SifreTekrar { get; set; } = null!;
    }
}
