using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApplication.Models
{
    public class Address
    {
        [Key]
        public long ID { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string ADDRESS_LINE { get; set; }
        public long ZIP_CODE { get; set; }
        public long USER_ID { get; set; }


    }
}
