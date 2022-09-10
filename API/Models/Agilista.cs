using System;

namespace AgilistaTracker {
  public class Agilista {
    public Agilista (string name, Category primaryFocus) {
      Name = name;
      PrimaryFocus = primaryFocus;
      Id = Guid.NewGuid ();
      SecondaryFocusId=Guid.Empty;
    }
    public Agilista (string name, Category primaryFocus, string twitterhandle) : this (name, primaryFocus) {
      TwitterHandle = twitterhandle;
    }
    private Agilista(){ }
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public Category PrimaryFocus { get; set; }
    public Guid PrimaryFocusId{get;set;}
    public string TwitterHandle { get; set; }
    public Category SecondaryFocus{get;set;}
    public Guid SecondaryFocusId { get; set; }
  }
}