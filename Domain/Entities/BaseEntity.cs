using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Entities;
public class BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public int Id { get; set; }
    [JsonPropertyOrder(999)]
    public DateTime? CreationDate { get; set; } = DateTime.Now;
    public int? CreatedBy { get; set; }
    [JsonPropertyOrder(999)]
    public DateTime? ModificationDate { get; set; } = DateTime.Now;
    [JsonPropertyOrder(999)]
    public int? ModifiedBy { get; set; }
    [JsonPropertyOrder(999)]
    public DateTime? DeletionDate { get; set; }
    [JsonPropertyOrder(999)]
    public bool IsDeleted { get; set; } = false;
}
