using GeekShopping.CouponAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CouponAPI.Model
{
    [Table("Coupon")]
    public class Coupon : BaseEntity
    {
        [Column("Coupon_Code")]
        [Required]
        [StringLength(30)]
        public string CouponCode { get; set; }

        [Column("DiscountAmount")]
        [Required]
        public decimal DiscountAmount { get; set; }
    }
}
