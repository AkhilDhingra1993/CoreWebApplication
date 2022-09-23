using System;
using System.ComponentModel.DataAnnotations;

namespace CoreWebApplication.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int CUSTOMER_USER_ID { get; set; }
        public int AMOUNT_PAID { get; set; }
        public DateTime DATE_CREATED { get; set; }
        public string PAYMENT_METHOD { get; set; }
        public string CUSTOMER_ADDRESS_CITY { get; set; }
        public string CUSTOMER_ADDRESS_STATE { get; set; }
        public string CUSTOMER_ADDRESS_COUNTRY { get; set; }
        public string CUSTOMER_ADDRESS_ADDRESS_LINE { get; set; }
        public long CUSTOMER_ADDRESS_ZIP_CODE { get; set; }
        public string CUSTOMER_ADDRESS_LABEL { get; set; }
    }
}
