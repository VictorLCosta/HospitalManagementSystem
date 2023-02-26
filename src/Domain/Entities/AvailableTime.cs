namespace Domain.Entities;

public class AvailableTime : BaseEntity
{
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public bool IsAvailable { get; set; }

    public Guid DoctorId { get; set; }
    public virtual Doctor Doctor { get; set; } = null!;
}
