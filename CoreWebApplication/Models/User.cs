using System.ComponentModel.DataAnnotations;

namespace CoreWebApplication.Models
{
    public class User
    {
        [Key]
        public long ID { get; set; }
        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office EMail")]
        public string EMAIL { get; set; }
        [Required]
        [MaxLength(30,ErrorMessage ="Name cannot exceed 30 charactors")]
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string LAST_NAME { get; set; }
        [Required]
        public string PASSWORD { get; set; }
        public bool IS_DELETED { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
