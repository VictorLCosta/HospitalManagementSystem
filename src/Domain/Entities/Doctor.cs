namespace Domain.Entities;

public class Doctor : BaseEntity
{
    public string CRM { get; set; }
    public string Phone { get; set; }
    
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
