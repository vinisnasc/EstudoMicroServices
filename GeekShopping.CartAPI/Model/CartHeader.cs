using GeekShopping.CartAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.Model
{
    [Table("CartHeader")]
    public class CartHeader : BaseEntity
    {
        [Column("user_id")]
        public string UserId { get; set; }

        [Column("cupon_code")]
        public string? CuponCode { get; set; }
    }
}
