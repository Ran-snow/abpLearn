using System.ComponentModel.DataAnnotations;

namespace HealthStory.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}