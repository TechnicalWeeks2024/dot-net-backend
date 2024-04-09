using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication35.Models
{
    public class User
    {
        [JsonIgnore]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("date_of_birth")]
        [JsonPropertyName("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [Column("zip_code")]
        [JsonPropertyName("zipCode")]
        public int? ZipCode { get; set; }

    }
}
