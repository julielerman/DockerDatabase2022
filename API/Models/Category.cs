using System;
namespace AgilistaTracker {
  public class Category {
    public Category (string description) {
      Id = Guid.NewGuid ();
      Description = description;
    }
    public Guid Id { get; private set; }
    public string Description { get; set; }
  }
}