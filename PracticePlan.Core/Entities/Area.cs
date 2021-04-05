using System.Collections.Generic;

namespace PracticePlan.Core.Entities
{
  public class Area
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Contact> Contacts { get; set; }
    public Address Address { get; set; }
  }
}
