using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CloudRiskCompliance.DomainClasses
{
    public class ApplicationUser : IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        // Add other properties here
        public virtual string CompanyId { get; set; }
        public virtual string DisplayName { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        public int? AddressId { get; set; }
    }
}