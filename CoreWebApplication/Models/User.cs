using System.ComponentModel.DataAnnotations;

namespace CoreWebApplication.Models
{
    public class User
    {
        public long ID { get; set; }
        public string EMAIL { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string PASSWORD { get; set; }
        public bool IS_DELETED { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
