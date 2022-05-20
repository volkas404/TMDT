using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class Bakery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bánh Ngọt");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Bánh Mặn");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Bánh Donut là món ăn được nhiều người yêu thích ở khắp nơi trên thế giới. Đó là những chiếc bánh đầy màu sắc thú vị với hình tròn dễ thương và nhiều hương vị khác nhau. Donut được ăn như món ngọt nhưng sau đó sự sáng tạo của những người làm bánh đã biến tấu nó với nhiều sản phẩm khác nhau, kể cả là món mặn.", "/Images/BanhNgot/donut.jpg", "Bánh Donut", 20000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Đây là loại bánh được làm từ bột mì, trứng, sữa và các loại trái cây từ phía Nam của Hà Lan. Loại bánh này không giòn, nó mềm như bánh mì.", "/Images/BanhNgot/limburgpie.jpg", "Bánh Limburg Pie", 95000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Macaron là một loại bánh ngọt dựa trên bánh trứng đường (một loại bánh bánh tráng miệng đặc trưng của ẩm thực Pháp, được làm bằng cách đánh lòng trứng đều lên và thêm chút đường cùng chút axit từ chanh tây hay giấm).", "/Images/BanhNgot/macaron.jpg", "Bánh Macaron", 10000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Mochi là một loại bánh giầy nhân ngọt và là một loại bánh truyền thống nổi tiếng ở Nhật. Loại bánh này không chỉ xuất hiện trong đời sống thường ngày của người Nhật mà còn mang ý nghĩa thiêng liêng vào những ngày lễ, ngày Tết tại Nhật.", "/Images/BanhNgot/mochi.jpg", "Bánh Mochi", 12000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 1, "Cấu tạo chung của chúng là bên trong sẽ là những lớp bánh quy xếp chồng lên nhau thành các lớp xen kẽ với các lớp kem, trứng, phô mai, cà phê, ca cao và cả rượu rum, tạo nên hương vị vô cùng đặc biệt cho tiramisu.", "/Images/BanhNgot/macaron.jpg", "Bánh Tiramisu", 45000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 2, "Trong bánh chứa nhân thịt nướng kèm với hương vị của thịt xá xíu. Bánh được phục vụ làm một loại dimsum trong thức ăn Yum cha và đôi khi được bày bàn ở các cửa hàng bánh Trung Quốc.", "/Images/BanhMan/banhbaoxaxiu.jpg", "Bánh bao xá xíu", 25000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 2, "Bánh bông lan trứng muối là món ăn vặt thơm ngon, bổ dưỡng được nhiều người yêu thích. Thường xuất hiện dưới hình dáng những chiếc cupcake nhỏ nhắn xinh xắn nhưng ít ai biết rằng bánh bông lan trứng muối còn có thể được làm thành bánh cỡ lớn để dùng làm món quà nhân dịp sinh nhật hay các ngày lễ kỷ niệm khác.", "/Images/BanhMan/banhbonglantrungmuoi.jpg", "Bánh bông lan trứng muối", 60000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 2, "Bánh có hình dáng giống chiếc quai vạc, bên trong nhân có thể chứa tôm, thịt (thường là thịt ba rọi) và các loại nhân khác, khi chế biến, bánh được gấp lại thành hình bán nguyệt và ép mép bánh, khi chín, viền bánh sẽ gợn sóng. Bánh quai vạc trần được làm từ bột mì tinh (bột mì lọc) thông qua quá trình luộc.", "/Images/BanhMan/banhquaivac.jpg", "Bánh quai vạc", 15000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 2, "Là một loại bánh rất mỏng, dẹt, thường được làm từ bột mì, trứng, sữa và bơ. Bánh kếp có nguồn gốc từ vùng Bretagne ở tây bắc Pháp, sau lan rộng ra toàn nước Pháp, trở thành món ăn truyền thống và phổ biến ở Pháp, Bỉ, Thụy Sĩ, Canada và Brazil.", "/Images/BanhMan/crepe.jpg", "Bánh Crepe", 25000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 2, "Là một loại bánh có hình tròn dẹt nổi tiếng khắp nơi trên thế giới. Nguyên liệu chính để tạo nên một chiếc bánh pizza đó chính là bột mỳ, nước và nấm lên men được ử ít nhất 1 ngày sau đó được nhào nặm thành hình dạng tròn đẹt rồi đem nướng chín trong lò.", "/Images/BanhMan/banhbaoxaxiu.jpg", "Bánh Pizza", 110000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "“Tako” là bạch tuộc, “Yaki” là nướng. Như vậy “Takoyaki” nghĩa là bánh bạch tuộc nướng. Bánh có hình dạng tròn như trái bóng nhỏ, rất dễ cầm và ăn chỉ với một cây tăm. Thông thường, người ta sẽ rưới lên bề mặt những chiếc bánh takoyaki một lớp nước xốt mặn ngọt hoặc Mayonnaise và dăm cá ngừ khô.", "/Images/BanhMan/takoyaki.jpg", "Bánh Takoyaki", 45000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Furniture");

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IconCSS", "Name" },
                values: new object[,]
                {
                    { 3, "fas fa-headphones", "Electronics" },
                    { 4, "fas fa-shoe-prints", "Shoes" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", "Cocooil - Organic Coconut Oil", 20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit", 30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 13, 2, "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m, 112 },
                    { 14, 2, "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m, 90 },
                    { 15, 2, "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m, 95 },
                    { 16, 2, "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m, 100 },
                    { 17, 2, "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m, 73 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 3, "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 3, "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones", 40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 3, "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones", 40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 3, "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod", 600m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 3, "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera", 500m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 3, "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy", 100m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 18, 4, "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers", 100m, 50 },
                    { 19, 4, "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers", 150m, 60 },
                    { 20, 4, "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers", 200m, 70 },
                    { 21, 4, "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120m, 120 },
                    { 22, 4, "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers", 200m, 100 },
                    { 23, 4, "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles", 50m, 150 }
                });
        }
    }
}
