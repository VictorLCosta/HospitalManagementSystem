namespace Domain.Entities;

public class Patient : BaseEntity
{
    public string CPF { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }

    public Address Address { get; set; } = null!;
    public MedicalRecord MedicalRecord { get; set; } = null!;

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
