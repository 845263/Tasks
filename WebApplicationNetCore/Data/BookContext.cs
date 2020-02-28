﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNetCore.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplicationNetCore.Data
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext>options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
            
    }
}
