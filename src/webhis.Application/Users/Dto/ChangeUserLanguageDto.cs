using System.ComponentModel.DataAnnotations;

namespace webhis.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}