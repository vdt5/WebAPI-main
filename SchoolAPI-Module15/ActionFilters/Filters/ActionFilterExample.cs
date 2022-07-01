using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters.Filters {
    public class ActionFilterExample : IActionFilter {
        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
