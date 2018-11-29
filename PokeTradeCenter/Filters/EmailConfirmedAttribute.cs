using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PokeTradeCenter.Areas.Identity.Data;

namespace PokeTradeCenter.Filters
{
    public class EmailConfirmedAttribute : ActionFilterAttribute
    {
        private UserManager<PokeTradeCenterUser> _userManager;

        public EmailConfirmedAttribute(UserManager<PokeTradeCenterUser> userManager)
        {
            _userManager = userManager;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                var user = _userManager.GetUserAsync(context.HttpContext.User);

                if (!user.Result.EmailConfirmed)
                {
                    context.Result = new UnauthorizedResult();
                }

            }
        }
    }
}