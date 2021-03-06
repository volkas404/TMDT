// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Data;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    [Migration("20220520141628_Bakery")]
    partial class Bakery
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Bánh táo Mỹ với phần vỏ bánh mỏng, giòn mềm, ẩn chứa phần nhân táo thơm ngọt, điểm chút vị chua dịu của trái cây quả sẽ là một lựa chọn hoàn hảo cho những tín đồ bánh ngọt trên toàn Thế Giới.",
                            ImageURL = "/Images/BanhNgot/banhtaomy.jpg",
                            Name = "Bánh táo mỹ",
                            Price = 100000m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Bánh Donut là món ăn được nhiều người yêu thích ở khắp nơi trên thế giới. Đó là những chiếc bánh đầy màu sắc thú vị với hình tròn dễ thương và nhiều hương vị khác nhau. Donut được ăn như món ngọt nhưng sau đó sự sáng tạo của những người làm bánh đã biến tấu nó với nhiều sản phẩm khác nhau, kể cả là món mặn.",
                            ImageURL = "/Images/BanhNgot/donut.jpg",
                            Name = "Bánh Donut",
                            Price = 20000m,
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Đây là loại bánh được làm từ bột mì, trứng, sữa và các loại trái cây từ phía Nam của Hà Lan. Loại bánh này không giòn, nó mềm như bánh mì.",
                            ImageURL = "/Images/BanhNgot/limburgpie.jpg",
                            Name = "Bánh Limburg Pie",
                            Price = 95000m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Macaron là một loại bánh ngọt dựa trên bánh trứng đường (một loại bánh bánh tráng miệng đặc trưng của ẩm thực Pháp, được làm bằng cách đánh lòng trứng đều lên và thêm chút đường cùng chút axit từ chanh tây hay giấm).",
                            ImageURL = "/Images/BanhNgot/macaron.jpg",
                            Name = "Bánh Macaron",
                            Price = 10000m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Mochi là một loại bánh giầy nhân ngọt và là một loại bánh truyền thống nổi tiếng ở Nhật. Loại bánh này không chỉ xuất hiện trong đời sống thường ngày của người Nhật mà còn mang ý nghĩa thiêng liêng vào những ngày lễ, ngày Tết tại Nhật.",
                            ImageURL = "/Images/BanhNgot/mochi.jpg",
                            Name = "Bánh Mochi",
                            Price = 12000m,
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Cấu tạo chung của chúng là bên trong sẽ là những lớp bánh quy xếp chồng lên nhau thành các lớp xen kẽ với các lớp kem, trứng, phô mai, cà phê, ca cao và cả rượu rum, tạo nên hương vị vô cùng đặc biệt cho tiramisu.",
                            ImageURL = "/Images/BanhNgot/macaron.jpg",
                            Name = "Bánh Tiramisu",
                            Price = 45000m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Trong bánh chứa nhân thịt nướng kèm với hương vị của thịt xá xíu. Bánh được phục vụ làm một loại dimsum trong thức ăn Yum cha và đôi khi được bày bàn ở các cửa hàng bánh Trung Quốc.",
                            ImageURL = "/Images/BanhMan/banhbaoxaxiu.jpg",
                            Name = "Bánh bao xá xíu",
                            Price = 25000m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Bánh bông lan trứng muối là món ăn vặt thơm ngon, bổ dưỡng được nhiều người yêu thích. Thường xuất hiện dưới hình dáng những chiếc cupcake nhỏ nhắn xinh xắn nhưng ít ai biết rằng bánh bông lan trứng muối còn có thể được làm thành bánh cỡ lớn để dùng làm món quà nhân dịp sinh nhật hay các ngày lễ kỷ niệm khác.",
                            ImageURL = "/Images/BanhMan/banhbonglantrungmuoi.jpg",
                            Name = "Bánh bông lan trứng muối",
                            Price = 60000m,
                            Qty = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "Bánh có hình dáng giống chiếc quai vạc, bên trong nhân có thể chứa tôm, thịt (thường là thịt ba rọi) và các loại nhân khác, khi chế biến, bánh được gấp lại thành hình bán nguyệt và ép mép bánh, khi chín, viền bánh sẽ gợn sóng. Bánh quai vạc trần được làm từ bột mì tinh (bột mì lọc) thông qua quá trình luộc.",
                            ImageURL = "/Images/BanhMan/banhquaivac.jpg",
                            Name = "Bánh quai vạc",
                            Price = 15000m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Là một loại bánh rất mỏng, dẹt, thường được làm từ bột mì, trứng, sữa và bơ. Bánh kếp có nguồn gốc từ vùng Bretagne ở tây bắc Pháp, sau lan rộng ra toàn nước Pháp, trở thành món ăn truyền thống và phổ biến ở Pháp, Bỉ, Thụy Sĩ, Canada và Brazil.",
                            ImageURL = "/Images/BanhMan/crepe.jpg",
                            Name = "Bánh Crepe",
                            Price = 25000m,
                            Qty = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "Là một loại bánh có hình tròn dẹt nổi tiếng khắp nơi trên thế giới. Nguyên liệu chính để tạo nên một chiếc bánh pizza đó chính là bột mỳ, nước và nấm lên men được ử ít nhất 1 ngày sau đó được nhào nặm thành hình dạng tròn đẹt rồi đem nướng chín trong lò.",
                            ImageURL = "/Images/BanhMan/banhbaoxaxiu.jpg",
                            Name = "Bánh Pizza",
                            Price = 110000m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "“Tako” là bạch tuộc, “Yaki” là nướng. Như vậy “Takoyaki” nghĩa là bánh bạch tuộc nướng. Bánh có hình dạng tròn như trái bóng nhỏ, rất dễ cầm và ăn chỉ với một cây tăm. Thông thường, người ta sẽ rưới lên bề mặt những chiếc bánh takoyaki một lớp nước xốt mặn ngọt hoặc Mayonnaise và dăm cá ngừ khô.",
                            ImageURL = "/Images/BanhMan/takoyaki.jpg",
                            Name = "Bánh Takoyaki",
                            Price = 45000m,
                            Qty = 212
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Name = "Bánh Ngọt"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-couch",
                            Name = "Bánh Mặn"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Sarah"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
