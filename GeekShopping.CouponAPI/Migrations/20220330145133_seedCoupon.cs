using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.CouponAPI.Migrations
{
    public partial class seedCoupon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "id", "Coupon_Code", "DiscountAmount" },
                values: new object[] { 1L, "vinicius123", 10m });

            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "id", "Coupon_Code", "DiscountAmount" },
                values: new object[] { 2L, "vinicius456", 15m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
