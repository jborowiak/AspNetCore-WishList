// Copyright © Titian Software Ltd

using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ApplicationDBContext(DbContextOptions options): base(options)
        {
            
        }  
    }
}
