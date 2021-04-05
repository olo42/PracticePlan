using System.Collections.Generic;

namespace PracticePlan.Core.Entities
{
  public class Schedule
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public List<Appointment> Appointments { get; set; }
  }
}
