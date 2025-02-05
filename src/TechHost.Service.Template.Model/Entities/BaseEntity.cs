using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechHost.Service.Template.Model.Entities;

public class BaseEntity
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }
    [Required]
    public DateTime DateModified { get; set; }

    /// <summary>
    /// Meant to validate concurrency en database update
    /// This column is updates itself in database and only works in postgresql
    /// </summary>
    [ConcurrencyCheck]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string xmin { get;}
}