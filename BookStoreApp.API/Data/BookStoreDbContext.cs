using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.API.Data;

public partial class BookStoreDbContext : IdentityDbContext<ApiUser>
{
	public BookStoreDbContext()
	{
	}

	public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
		: base(options)
	{
	}

	public virtual DbSet<Author> Authors { get; set; }

	public virtual DbSet<Book> Books { get; set; }

	//public virtual DbSet<CodeFirstTable> CodeFirstTables { get; set; }


	//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
	//        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BookStoreDb;Integrated Security=True;Trust Server Certificate=True");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Author>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC0701CC0B0A");

			entity.Property(e => e.Bio).HasMaxLength(250);
			entity.Property(e => e.FirstName).HasMaxLength(50);
			entity.Property(e => e.LastName).HasMaxLength(50);
		});

		modelBuilder.Entity<Book>(entity =>
		{
			entity.HasKey(e => e.Id).HasName("PK__Books__3214EC07C5076328");

			entity.HasIndex(e => e.Isbn, "UQ__Books__447D36EA90C5EE2C").IsUnique();

			entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
			entity.Property(e => e.Image).HasMaxLength(50);
			entity.Property(e => e.Isbn)
				.HasMaxLength(50)
				.HasColumnName("ISBN");
			entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
			entity.Property(e => e.Summary).HasMaxLength(250);
			entity.Property(e => e.Title).HasMaxLength(50);

			entity.HasOne(d => d.Author).WithMany(p => p.Books)
				.HasForeignKey(d => d.AuthorId)
				.HasConstraintName("FK_Books_ToTable");
		});

		modelBuilder.Entity<IdentityRole>().HasData(
			new IdentityRole
			{
				Name = "User",
				NormalizedName = "USER",
				Id = "b8cce846-0fa4-4c0a-9db3-8441222ff29d"

			},
			new IdentityRole
			{
				Name = "Administrator",
				NormalizedName = "ADMINISTRATOR",
				Id = "9902c2a7-3346-4a98-a4ed-a45f2a03811e"

			}
		);

		var hasher = new PasswordHasher<ApiUser>();

		modelBuilder.Entity<ApiUser>().HasData(
		   new ApiUser
		   {
			   Id = "4a76952b-d20b-4d26-a671-aaaf7779488b",
			   Email = "admin@bookstore.com",
			   NormalizedEmail = "ADMIN@BOOKSTORE.COM",
			   UserName = "admin@bookstore.com",
			   NormalizedUserName‌ = "ADMIN@BOOKSTORE.COM",
			   FirstName = "System",
			   LastName = "Admin",
			   PasswordHash = hasher.HashPassword(null, "P@ssword1")
		   },
		   new ApiUser
		   {
			   Id = "c0b79b5d-7987-4214-9cc6-f7f5be3b3d42",
			   Email = "user@bookstore.com",
			   NormalizedEmail = "USER@BOOKSTORE.COM",
			   UserName = "user@bookstore.com",
			   NormalizedUserName‌ = "USER@BOOKSTORE.COM",
			   FirstName = "System",
			   LastName = "User",
			   PasswordHash = hasher.HashPassword(null, "P@ssword1")
		   }
	   );

		modelBuilder.Entity<IdentityUserRole<string>>().HasData(
			new IdentityUserRole<string>
			{
				RoleId = "b8cce846-0fa4-4c0a-9db3-8441222ff29d",
				UserId = "c0b79b5d-7987-4214-9cc6-f7f5be3b3d42"
			},
			new IdentityUserRole<string>
			{
				RoleId = "9902c2a7-3346-4a98-a4ed-a45f2a03811e",
				UserId = "4a76952b-d20b-4d26-a671-aaaf7779488b"
			}
		);

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
