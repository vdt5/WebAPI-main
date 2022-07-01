using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ActionFilters {
    public abstract class ActionFilterAttribute : Attribute, IActionFilter, IFilterMetadata, IAsyncActionFilter, IResultFilter, IAsyncResultFilter, IOrderedFilter { }
}
