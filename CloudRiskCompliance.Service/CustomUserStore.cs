using CloudRiskCompliance.DomainClasses;
using CloudRiskCompliance.ServiceLayer.Contracts;
using Microsoft.AspNet.Identity;

namespace CloudRiskCompliance.ServiceLayer
{
    public class CustomUserStore : ICustomUserStore
    {
        private readonly IUserStore<ApplicationUser, int> _userStore;

        public CustomUserStore(IUserStore<ApplicationUser, int> userStore)
        {
            _userStore = userStore;
        }


    }
}