namespace Domain.Entities;

#nullable disable
public class Address : BaseEntity
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }

    public Guid PatientId { get; set; }
    public Patient Patient { get; set; } = null!;
}
