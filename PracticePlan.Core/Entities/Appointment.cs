using System;

namespace PracticePlan.Core.Entities
{
  public class Appointment
  {
    public int Id { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public Area Area { get; set; }
  }
}