using System.ComponentModel.DataAnnotations.Schema;
using SoftSesApi.Abstracts;

namespace SoftSesApi.Model.Financial;

[Table("payment_method", Schema = "financial")]
public class PaymentMethod : BaseModel
{
    public Guid Id { get; set; }
}