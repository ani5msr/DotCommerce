using Microsoft.EntityFrameworkCore;
using DotCommerce.Models.Entities;
using DotCommerce.Models.Entities.Base;

public class StoreContext : DbContext
{
 public StoreContext(DbContextOptions<StoreContext> options)
 : base(options)
 {
 }
 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
 }
}