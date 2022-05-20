using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext:DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			//Bánh Ngọt

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "Bánh táo mỹ",
				Description = "Bánh táo Mỹ với phần vỏ bánh mỏng, giòn mềm, ẩn chứa phần nhân táo thơm ngọt, điểm chút vị chua dịu của trái cây quả sẽ là một lựa chọn hoàn hảo cho những tín đồ bánh ngọt trên toàn Thế Giới.",
				ImageURL = "/Images/BanhNgot/banhtaomy.jpg",
				Price = 100000,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "Bánh Donut",
				Description = "Bánh Donut là món ăn được nhiều người yêu thích ở khắp nơi trên thế giới. Đó là những chiếc bánh đầy màu sắc thú vị với hình tròn dễ thương và nhiều hương vị khác nhau. Donut được ăn như món ngọt nhưng sau đó sự sáng tạo của những người làm bánh đã biến tấu nó với nhiều sản phẩm khác nhau, kể cả là món mặn.",
				
				ImageURL = "/Images/BanhNgot/donut.jpg",
				Price = 20000,
				Qty = 45,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "Bánh Limburg Pie",
				Description = "Đây là loại bánh được làm từ bột mì, trứng, sữa và các loại trái cây từ phía Nam của Hà Lan. Loại bánh này không giòn, nó mềm như bánh mì.",
				ImageURL = "/Images/BanhNgot/limburgpie.jpg",
				Price = 95000,
				Qty = 30,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Bánh Macaron",
				Description = "Macaron là một loại bánh ngọt dựa trên bánh trứng đường (một loại bánh bánh tráng miệng đặc trưng của ẩm thực Pháp, được làm bằng cách đánh lòng trứng đều lên và thêm chút đường cùng chút axit từ chanh tây hay giấm).",
				ImageURL = "/Images/BanhNgot/macaron.jpg",
				Price = 10000,
				Qty = 60,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = "Bánh Mochi",
				Description = "Mochi là một loại bánh giầy nhân ngọt và là một loại bánh truyền thống nổi tiếng ở Nhật. Loại bánh này không chỉ xuất hiện trong đời sống thường ngày của người Nhật mà còn mang ý nghĩa thiêng liêng vào những ngày lễ, ngày Tết tại Nhật.",
				ImageURL = "/Images/BanhNgot/mochi.jpg",
				Price = 12000,
				Qty = 85,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 24,
				Name = "Bánh Tiramisu",
				Description = "Cấu tạo chung của chúng là bên trong sẽ là những lớp bánh quy xếp chồng lên nhau thành các lớp xen kẽ với các lớp kem, trứng, phô mai, cà phê, ca cao và cả rượu rum, tạo nên hương vị vô cùng đặc biệt cho tiramisu.",
				ImageURL = "/Images/BanhNgot/macaron.jpg",
				Price = 45000,
				Qty = 120,
				CategoryId = 1

			});
			//bánh mặn
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 25,
				Name = "Bánh bao xá xíu",
				Description = "Trong bánh chứa nhân thịt nướng kèm với hương vị của thịt xá xíu. Bánh được phục vụ làm một loại dimsum trong thức ăn Yum cha và đôi khi được bày bàn ở các cửa hàng bánh Trung Quốc.",
				ImageURL = "/Images/BanhMan/banhbaoxaxiu.jpg",
				Price = 25000,
				Qty = 200,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 26,
				Name = "Bông lan trứng muối",
				Description = "Bánh bông lan trứng muối là món ăn vặt thơm ngon, bổ dưỡng được nhiều người yêu thích. Thường xuất hiện dưới hình dáng những chiếc cupcake nhỏ nhắn xinh xắn nhưng ít ai biết rằng bánh bông lan trứng muối còn có thể được làm thành bánh cỡ lớn để dùng làm món quà nhân dịp sinh nhật hay các ngày lễ kỷ niệm khác.",
				ImageURL = "/Images/BanhMan/banhbonglantrungmuoi.jpg",
				Price = 60000,
				Qty = 300,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 27,
				Name = "Bánh quai vạc",
				Description = "Bánh có hình dáng giống chiếc quai vạc, bên trong nhân có thể chứa tôm, thịt (thường là thịt ba rọi) và các loại nhân khác, khi chế biến, bánh được gấp lại thành hình bán nguyệt và ép mép bánh, khi chín, viền bánh sẽ gợn sóng. Bánh quai vạc trần được làm từ bột mì tinh (bột mì lọc) thông qua quá trình luộc.",
				ImageURL = "/Images/BanhMan/banhquaivac.jpg",
				Price = 15000,
				Qty = 20,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 28,
				Name = "Bánh Crepe",
				Description = "Là một loại bánh rất mỏng, dẹt, thường được làm từ bột mì, trứng, sữa và bơ. Bánh kếp có nguồn gốc từ vùng Bretagne ở tây bắc Pháp, sau lan rộng ra toàn nước Pháp, trở thành món ăn truyền thống và phổ biến ở Pháp, Bỉ, Thụy Sĩ, Canada và Brazil.",
				ImageURL = "/Images/BanhMan/crepe.jpg",
				Price = 25000,
				Qty = 15,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 29,
				Name = "Bánh Pizza",
				Description = "Là một loại bánh có hình tròn dẹt nổi tiếng khắp nơi trên thế giới. Nguyên liệu chính để tạo nên một chiếc bánh pizza đó chính là bột mỳ, nước và nấm lên men được ử ít nhất 1 ngày sau đó được nhào nặm thành hình dạng tròn đẹt rồi đem nướng chín trong lò.",
				ImageURL = "/Images/BanhMan/banhbaoxaxiu.jpg",
				Price = 110000,
				Qty = 60,
				CategoryId = 2
			});
			
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 12,
				Name = "Bánh Takoyaki",
				Description = "“Tako” là bạch tuộc, “Yaki” là nướng. Như vậy “Takoyaki” nghĩa là bánh bạch tuộc nướng. Bánh có hình dạng tròn như trái bóng nhỏ, rất dễ cầm và ăn chỉ với một cây tăm. Thông thường, người ta sẽ rưới lên bề mặt những chiếc bánh takoyaki một lớp nước xốt mặn ngọt hoặc Mayonnaise và dăm cá ngừ khô.",
				ImageURL = "/Images/BanhMan/takoyaki.jpg",
				Price = 45000,
				Qty = 212,
				CategoryId = 2
			});

			
			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Bob"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Sarah"

			});

			//Create Shopping Cart for Users
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 1,
				UserId = 1

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 2,
				UserId = 2

			});
			//Add Product Categories
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Bánh Ngọt",
				IconCSS = "fas fa-cheese"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Bánh Mặn",
				IconCSS = "fas fa-pizza-slice"
			});
		}

		public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
