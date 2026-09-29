using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

namespace BlogApp.Data.Concrete.EfCore
{
    public class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Entity.Tag { Text = "web programlama", Url = "web-programlama" , Color = Entity.TagColors.warning},
                        new Entity.Tag { Text = "backend", Url = "backend", Color = Entity.TagColors.info},
                        new Entity.Tag { Text = "frontend", Url = "frontend", Color = Entity.TagColors.success},
                        new Entity.Tag { Text = "fullstack" , Url = "fullstack", Color = Entity.TagColors.secondary },
                        new Entity.Tag { Text = "php" , Url = "php" , Color = Entity.TagColors.primary }
                        );
                    context.SaveChanges();
                }
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new Entity.User { UserName = "emregul", Name = "Emre Gül", Email = "info@emregul.com", Password = "123456", Image = "p1.jpg" },
                        new Entity.User { UserName = "ahmetyilmaz", Name = "Ahmet Yılmaz", Email = "info@ahmetyilmaz.com", Password = "123456", Image = "p2.jpg" }

                    ); 
                    context.SaveChanges() ;
                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Entity.Post
                        {
                            Title = "Asp.net Core",
                            Description = "Asp.net core dersleri",
                            Content = "Asp.net core dersleri",
                            Url = "aspnet-core",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            Image = "1.jpg",
                            UserId = 1,
                            Comments = new List<Comment> {
                                new Comment {Text = "iyi bir kurs", PublishedOn =DateTime.Now.AddDays(-20), UserId = 1},
                                new Comment {Text = "çok faydalandığım bir kurs", PublishedOn = DateTime.Now.AddDays(-10), UserId = 2}
                                } 
                        },
                        new Entity.Post
                        {
                            Title = "Php",
                            Description = "Php dersleri",
                            Content = "Php dersleri",
                            Url = "php",
                            IsActive = true,
                            Image = "2.jpg",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 1
                        },
                        new Entity.Post
                        {
                            Title = "Django ",
                            Description = "Django dersleri",
                            Content = "Django dersleri",
                            Url = "django",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(1).ToList(),
                            UserId = 1
                        },
                        new Entity.Post
                        {
                            Title = "React ",
                            Description = "React dersleri",
                            Content = "React dersleri",
                            Url = "react",
                            IsActive = true,
                            Image = "2.jpg",
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1
                        },
                        new Entity.Post
                        {
                            Title = "Angular ",
                            Description = "Angular dersleri",
                            Content = "Angular dersleri",
                            Url = "angular",
                            IsActive = true,
                            Image = "1.jpg",
                            PublishedOn = DateTime.Now.AddDays(-50),
                            Tags = context.Tags.Take(5).ToList(),
                            UserId = 1
                        },
                        new Entity.Post
                        {
                            Title = "Web Tasarım ",
                            Description = "Web Tasarım dersleri",
                            Content = "Web Tasarım dersleri",
                            Url = "web-tasarim",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-60),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 1
                        }
                    );
                    context.SaveChanges();
                }

            }

        }
    }
}

