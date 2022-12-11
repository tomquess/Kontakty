﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KontaktyBackend.Models
{
    public class KontaktModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Imie { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nazwisko { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [PasswordPropertyText]
        public string Haslo { get; set; }


        public string Kategoria { get; set; }

        public string Podkategoria { get; set; }

        [Phone]
        public string Telefon { get; set; }

        public DateTime Dataurodzenia { get; set; }

    }
}
