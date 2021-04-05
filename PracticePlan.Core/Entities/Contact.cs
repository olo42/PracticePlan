namespace PracticePlan.Core.Entities
{
  public class Contact
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public Address Address { get; set; }
  }
}
