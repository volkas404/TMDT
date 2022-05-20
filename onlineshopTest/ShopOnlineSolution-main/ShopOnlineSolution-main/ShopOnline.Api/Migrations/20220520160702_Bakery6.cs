using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class Bakery6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 24, 1, "Cấu tạo chung của chúng là bên trong sẽ là những lớp bánh quy xếp chồng lên nhau thành các lớp xen kẽ với các lớp kem, trứng, phô mai, cà phê, ca cao và cả rượu rum, tạo nên hương vị vô cùng đặc biệt cho tiramisu.", "/Images/BanhNgot/macaron.jpg", "Bánh Tiramisu", 45000m, 120 },
                    { 25, 2, "Trong bánh chứa nhân thịt nướng kèm với hương vị của thịt xá xíu. Bánh được phục vụ làm một loại dimsum trong thức ăn Yum cha và đôi khi được bày bàn ở các cửa hàng bánh Trung Quốc.", "/Images/BanhMan/banhbaoxaxiu.jpg", "Bánh bao xá xíu", 25000m, 200 },
                    { 26, 2, "Bánh bông lan trứng muối là món ăn vặt thơm ngon, bổ dưỡng được nhiều người yêu thích. Thường xuất hiện dưới hình dáng những chiếc cupcake nhỏ nhắn xinh xắn nhưng ít ai biết rằng bánh bông lan trứng muối còn có thể được làm thành bánh cỡ lớn để dùng làm món quà nhân dịp sinh nhật hay các ngày lễ kỷ niệm khác.", "/Images/BanhMan/banhbonglantrungmuoi.jpg", "Bông lan trứng muối", 60000m, 300 },
                    { 27, 2, "Bánh có hình dáng giống chiếc quai vạc, bên trong nhân có thể chứa tôm, thịt (thường là thịt ba rọi) và các loại nhân khác, khi chế biến, bánh được gấp lại thành hình bán nguyệt và ép mép bánh, khi chín, viền bánh sẽ gợn sóng. Bánh quai vạc trần được làm từ bột mì tinh (bột mì lọc) thông qua quá trình luộc.", "/Images/BanhMan/banhquaivac.jpg", "Bánh quai vạc", 15000m, 20 },
                    { 28, 2, "Là một loại bánh rất mỏng, dẹt, thường được làm từ bột mì, trứng, sữa và bơ. Bánh kếp có nguồn gốc từ vùng Bretagne ở tây bắc Pháp, sau lan rộng ra toàn nước Pháp, trở thành món ăn truyền thống và phổ biến ở Pháp, Bỉ, Thụy Sĩ, Canada và Brazil.", "/Images/BanhMan/crepe.jpg", "Bánh Crepe", 25000m, 15 },
                    { 29, 2, "Là một loại bánh có hình tròn dẹt nổi tiếng khắp nơi trên thế giới. Nguyên liệu chính để tạo nên một chiếc bánh pizza đó chính là bột mỳ, nước và nấm lên men được ử ít nhất 1 ngày sau đó được nhào nặm thành hình dạng tròn đẹt rồi đem nướng chín trong lò.", "/Images/BanhMan/banhbaoxaxiu.jpg", "Bánh Pizza", 110000m, 60 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 6, 1, "Cấu tạo chung của chúng là bên trong sẽ là những lớp bánh quy xếp chồng lên nhau thành các lớp xen kẽ với các lớp kem, trứng, phô mai, cà phê, ca cao và cả rượu rum, tạo nên hương vị vô cùng đặc biệt cho tiramisu.", "/Images/BanhNgot/macaron.jpg", "Bánh Tiramisu", 45000m, 120 },
                    { 7, 2, "Trong bánh chứa nhân thịt nướng kèm với hương vị của thịt xá xíu. Bánh được phục vụ làm một loại dimsum trong thức ăn Yum cha và đôi khi được bày bàn ở các cửa hàng bánh Trung Quốc.", "/Images/BanhMan/banhbaoxaxiu.jpg", "Bánh bao xá xíu", 25000m, 200 },
                    { 8, 2, "Bánh bông lan trứng muối là món ăn vặt thơm ngon, bổ dưỡng được nhiều người yêu thích. Thường xuất hiện dưới hình dáng những chiếc cupcake nhỏ nhắn xinh xắn nhưng ít ai biết rằng bánh bông lan trứng muối còn có thể được làm thành bánh cỡ lớn để dùng làm món quà nhân dịp sinh nhật hay các ngày lễ kỷ niệm khác.", "/Images/BanhMan/banhbonglantrungmuoi.jpg", "Bánh bông lan trứng muối", 60000m, 300 },
                    { 9, 2, "Bánh có hình dáng giống chiếc quai vạc, bên trong nhân có thể chứa tôm, thịt (thường là thịt ba rọi) và các loại nhân khác, khi chế biến, bánh được gấp lại thành hình bán nguyệt và ép mép bánh, khi chín, viền bánh sẽ gợn sóng. Bánh quai vạc trần được làm từ bột mì tinh (bột mì lọc) thông qua quá trình luộc.", "/Images/BanhMan/banhquaivac.jpg", "Bánh quai vạc", 15000m, 20 },
                    { 10, 2, "Là một loại bánh rất mỏng, dẹt, thường được làm từ bột mì, trứng, sữa và bơ. Bánh kếp có nguồn gốc từ vùng Bretagne ở tây bắc Pháp, sau lan rộng ra toàn nước Pháp, trở thành món ăn truyền thống và phổ biến ở Pháp, Bỉ, Thụy Sĩ, Canada và Brazil.", "/Images/BanhMan/crepe.jpg", "Bánh Crepe", 25000m, 15 },
                    { 11, 2, "Là một loại bánh có hình tròn dẹt nổi tiếng khắp nơi trên thế giới. Nguyên liệu chính để tạo nên một chiếc bánh pizza đó chính là bột mỳ, nước và nấm lên men được ử ít nhất 1 ngày sau đó được nhào nặm thành hình dạng tròn đẹt rồi đem nướng chín trong lò.", "/Images/BanhMan/banhbaoxaxiu.jpg", "Bánh Pizza", 110000m, 60 }
                });
        }
    }
}
