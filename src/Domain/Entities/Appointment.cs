namespace Domain.Entities;

public class Appointment : BaseEntity
{
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }

    public string? Description { get; set; }

    public Guid PatientId { get; set; }
    public virtual Patient Patient { get; set; } = null!;
    public Guid DoctorId { get; set; }
    public virtual Doctor Doctor { get; set; } = null!;
}
