using System.ComponentModel.DataAnnotations;

namespace Tolo.MyAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}