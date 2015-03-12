using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudRiskCompliance.DomainClasses
{
    public class Document
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
