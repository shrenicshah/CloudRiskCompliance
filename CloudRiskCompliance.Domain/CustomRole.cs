using Microsoft.AspNet.Identity.EntityFramework;

namespace CloudRiskCompliance.DomainClasses
{
    public class CustomRole : IdentityRole<int, CustomUserRole>
    {
        public CustomRole() { }
        public CustomRole(string name) { Name = name; }


    }
}