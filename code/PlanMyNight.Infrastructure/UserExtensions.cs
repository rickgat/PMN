namespace Microsoft.Samples.PlanMyNight.Infrastructure
{
    using System;
    using System.Security.Principal;

    public static class UserExtensions
    {
        public static Guid UserId(this IPrincipal user)
        {
            if (user != null && user.Identity != null && !string.IsNullOrEmpty(user.Identity.Name))
            {
                return new Guid(user.Identity.Name);
            }

            return Guid.Empty;
        }
    }
}
