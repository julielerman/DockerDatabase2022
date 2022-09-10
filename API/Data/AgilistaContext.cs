using System;
using AgilistaTracker;
using Microsoft.EntityFrameworkCore;

public class AgilistaContext : DbContext {
  public AgilistaContext (DbContextOptions<AgilistaContext> options) : base (options) { }

  public AgilistaContext () { }
  public DbSet<Agilista> Agilistas { get; set; }
  public DbSet<Category> Categories { get; set; }
  protected override void OnModelCreating (ModelBuilder modelBuilder) {
    modelBuilder.Entity<Category> ().HasData (
      new { Id = new Guid ("167d1f6b-a93d-49e4-8a0d-e651369e018b"), Description = "Agile Testing" },
      new { Id = new Guid ("5f6d6f80-9f9a-469e-9036-07ecbb3971ea"), Description = "Exploratory Testing" },
      new { Id = new Guid ("c5b6a0e8-e43f-4765-906f-e15e019a19d8"), Description = "Psychology of Collaboration" },
      new { Id = new Guid ("a372269c-0e3d-45f6-bda1-6631667e8e37"), Description = "Agile Data" }
      

    );

modelBuilder.Entity<Agilista> ().HasData (
      new { Id = new Guid ("5efdb55d-1205-419f-8a0b-9cc7a15f8565"), Name = "Lisa Crispin", PrimaryFocusId = new Guid ("167d1f6b-a93d-49e4-8a0d-e651369e018b") },
      new { Id = new Guid ("554be900-d1a4-4908-9d6a-5ef3ea05650e"), Name = "Janet Gregory", PrimaryFocusId = new Guid ("167d1f6b-a93d-49e4-8a0d-e651369e018b") },
      new { Id = new Guid ("f2e5fdba-daf9-43f0-8bde-9ed2562bd12a"), Name = "Maaret Pyhäjärvi", PrimaryFocusId = new Guid ("5f6d6f80-9f9a-469e-9036-07ecbb3971ea")},
      new { Id = new Guid ("83eda86f-c652-4666-ba17-db90b218a54b"), Name = "Linda Rising", PrimaryFocusId = new Guid ("c5b6a0e8-e43f-4765-906f-e15e019a19d8") },
      new { Id = new Guid ("cb2a97da-1700-4f2b-a419-c539279e0d1f"), Name = "Julie Lerman", PrimaryFocusId = new Guid ("a372269c-0e3d-45f6-bda1-6631667e8e37") }

    );

  }
}