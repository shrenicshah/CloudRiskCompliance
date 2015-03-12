using CloudRiskCompliance.DomainClasses;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudRiskCompliance.ServiceLayer
{
    public class CustomUserValidator : UserValidator<ApplicationUser, int>
    {
        private ApplicationUserManager _manager;

        public CustomUserValidator(ApplicationUserManager manager)
            : base(manager: manager)
        {
            _manager = manager;
        }

        public override async System.Threading.Tasks.Task<IdentityResult> ValidateAsync(ApplicationUser user)
        {
            IdentityResult result = await base.ValidateAsync(user);
            var userResult = _manager.FindByEmail(user.Email);

            if (userResult != null && userResult.CompanyId.ToLower() == user.CompanyId.ToLower())
            {
                var errors = result.Errors.ToList();
                errors.Add("Username already exists.");
                result = new IdentityResult(errors);
            }
            //if (userResult != null && userResult.CompanyId.ToLower() != user.CompanyId.ToLower())
            //{
            //    return IdentityResult.Success;
            //}
            //else if (userResult == null)
            //{
            //    return result;
            //    //return new IdentityResult(); 
            //}
            
            //if (!user.Email.ToLower().EndsWith("@example.com"))
            //{
            //    var errors = result.Errors.ToList();
            //    errors.Add("Only example.com email addresses are allowed");
            //    result = new IdentityResult(errors);
            //}
            return result;
        }
    }
}
