using CloudRiskCompliance.DomainClasses;
using CloudRiskCompliance.ServiceLayer.Contracts;
using Microsoft.AspNet.Identity;

namespace CloudRiskCompliance.ServiceLayer
{
    public class CustomRoleStore : ICustomRoleStore
    {
        private readonly IRoleStore<CustomRole, int> _roleStore;

        public CustomRoleStore(IRoleStore<CustomRole, int> roleStore)
        {
            _roleStore = roleStore;
        }
    }
}