using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationNetCore.Data;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplicationNetCore.Models
{
    public class Sealed
    {
        public static void Initializer(IServiceProvider serviceprovider)
        {
            using (var context = new BookContext(serviceprovider.GetRequiredService<DbContextOptions<BookContext>>()))
            {



                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book
                    {
                        Btitle = "Indian stories",
                        Category = "Friction;",
                        Price = 4000,
                        Authorname = "Narayan",
                        Publisher = "penguin",
                        ReleaseDate = Convert.ToDateTime("10-09-2014")


                    }
                  
                        );
                context.SaveChanges();
            }
        }
    }
}
