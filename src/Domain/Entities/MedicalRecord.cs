namespace Domain.Entities;

public class MedicalRecord : BaseEntity
{
    public string? Notes { get; set; }

    public Guid PatientId { get; set; }
    public virtual Patient Patient { get; set; } = null!;

    public virtual ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();
}
