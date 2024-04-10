using System.ComponentModel.DataAnnotations;

namespace Buiscuiterie.Authentification
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Le nom d'utilisateur est requis")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "L'adresse courriel est requise")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        public string? Password { get; set; }
    }

}
