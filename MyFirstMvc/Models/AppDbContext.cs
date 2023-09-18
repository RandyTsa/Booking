using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyFirstMvc.Models
{
	public partial class AppDbContext : DbContext
	{
		public AppDbContext()
			: base("name=AppDbContext")
		{
		}

		public virtual DbSet<CartItem> CartItems { get; set; }
		public virtual DbSet<Cart> Carts { get; set; }
		public virtual DbSet<Member> Members { get; set; }
		public virtual DbSet<News> News { get; set; }
		public virtual DbSet<NewsImage> NewsImages { get; set; }
		public virtual DbSet<OrderItem> OrderItems { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<Payment> Payments { get; set; }
		public virtual DbSet<Photo> Photos { get; set; }
		public virtual DbSet<Question> Questions { get; set; }
		public virtual DbSet<Room> Rooms { get; set; }
		public virtual DbSet<RoomService> RoomServices { get; set; }
		public virtual DbSet<Roomtype> Roomtypes { get; set; }
		public virtual DbSet<Service> Services { get; set; }
		public virtual DbSet<UserNewsRelationship> UserNewsRelationships { get; set; }
		public virtual DbSet<UserQuestionRelationship> UserQuestionRelationships { get; set; }
		public virtual DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cart>()
				.HasMany(e => e.CartItems)
				.WithRequired(e => e.Cart)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Member>()
				.Property(e => e.PhoneNum)
				.IsUnicode(false);

			modelBuilder.Entity<Member>()
				.HasMany(e => e.Carts)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Member>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<News>()
				.HasMany(e => e.NewsImages)
				.WithRequired(e => e.News)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<News>()
				.HasMany(e => e.UserNewsRelationships)
				.WithRequired(e => e.News)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Order>()
				.HasMany(e => e.OrderItems)
				.WithRequired(e => e.Order)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Payment>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Payment)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Photo>()
				.Property(e => e.URL)
				.IsUnicode(false);

			modelBuilder.Entity<Question>()
				.HasMany(e => e.UserQuestionRelationships)
				.WithRequired(e => e.Question)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Room>()
				.HasMany(e => e.CartItems)
				.WithRequired(e => e.Room)
				.HasForeignKey(e => e.CartId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Room>()
				.HasMany(e => e.OrderItems)
				.WithRequired(e => e.Room)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Room>()
				.HasMany(e => e.Photos)
				.WithRequired(e => e.Room)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Room>()
				.HasMany(e => e.RoomServices)
				.WithRequired(e => e.Room)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Roomtype>()
				.HasMany(e => e.Photos)
				.WithRequired(e => e.Roomtype)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Service>()
				.HasMany(e => e.RoomServices)
				.WithRequired(e => e.Service)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Password)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.HasMany(e => e.UserNewsRelationships)
				.WithRequired(e => e.User)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<User>()
				.HasMany(e => e.UserQuestionRelationships)
				.WithRequired(e => e.User)
				.WillCascadeOnDelete(false);
		}
	}
}
