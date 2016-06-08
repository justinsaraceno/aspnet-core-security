using Microsoft.AspNetCore.Authorization;

namespace aspnet_core_security
{
    public class StatusRequirement : AuthorizationHandler<StatusRequirement>, IAuthorizationRequirement
    {
        private readonly string _status;
        private readonly string _company;

        public StatusRequirement(string company, string status, bool isSupervisorAllowed = true)
        {
            this._company = company;
            _status = status;
        }

        protected override void Handle(AuthorizationContext context, StatusRequirement requirement)
        {
            if (context.User.IsInRole("administrator"))
            {
                context.Succeed(requirement);
                return;
            }

            if (context.User.HasClaim("company", this._company) &&
                context.User.HasClaim("status", _status))
            {
                context.Succeed(requirement);
            }
        }
    }
}
