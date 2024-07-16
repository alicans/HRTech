
using System.ComponentModel.DataAnnotations;

namespace IdentityDenemeHRTech.Models
{
    public class SifreKarsilastirmaAttribute : ValidationAttribute
    {
        private readonly string _eskiSifrePropertyName;

        public SifreKarsilastirmaAttribute(string eskiSifrePropertyName)
        {
            _eskiSifrePropertyName = eskiSifrePropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var eskiSifreProperty = validationContext.ObjectType.GetProperty(_eskiSifrePropertyName);            

            var eskiSifreValue = eskiSifreProperty.GetValue(validationContext.ObjectInstance, null);
            var yeniSifreValue = value as string;

            if (eskiSifreValue != null && yeniSifreValue != null && eskiSifreValue.Equals(yeniSifreValue))
            {
                return new ValidationResult("Yeni şifre ile eski şifre aynı olamaz.");
            }

            return ValidationResult.Success;
        }
    }
}