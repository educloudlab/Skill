using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AisectOnline.Services.Modules.Users;

namespace AisectOnline.Services.Modules.Base
{

    /// <summary>
    /// BaseController provides common functionality for all MVC controllers.
    /// Inherit from this class to get centralized logging, error handling, user info, and standardized responses.
    /// </summary>
    public abstract class BaseController : Controller
    {
        protected readonly ILogger _logger;


        /*protected readonly ILogger _logger;
        protected readonly IUserContextService _userContext;
        protected readonly ISessionContextService _sessionContext;

        protected BaseController(
            ILogger logger,
            IUserContextService userContext,
            ISessionContextService sessionContext)
        {
            _logger = logger;
            _userContext = userContext;
            _sessionContext = sessionContext;
        }*/
        protected BaseController(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets the current authenticated user's ID from claims.
        /// </summary>
        protected string CurrentUserId => User.FindFirstValue(ClaimTypes.NameIdentifier);

        /// <summary>
        /// Standard success response for AJAX or API calls.
        /// </summary>
        protected IActionResult Success<T>(T data)
        {
            var payload = new ApiResponse<T>
            {
                Success = true,
                Data = data
            };
            return Ok(payload);
        }

        /// <summary>
        /// Standard failure response for AJAX or API calls.
        /// </summary>
        protected IActionResult Failure(string errorMessage, int statusCode = 400)
        {
            var payload = new ApiResponse<object>
            {
                Success = false,
                Error = errorMessage
            };
            return StatusCode(statusCode, payload);
        }

        /// <summary>
        /// Override OnActionExecuting to perform common pre-action logic.
        /// E.g., logging, model-state checks, etc.
        /// </summary>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Executing action: {Controller}.{Action}",
                context.ActionDescriptor.RouteValues["controller"],
                context.ActionDescriptor.RouteValues["action"]);

            // Example: enforce model validation globally
            if (!ModelState.IsValid)
            {
                context.Result = Failure("Validation failed", 422);
            }

            base.OnActionExecuting(context);
        }

        /// <summary>
        /// Override OnActionExecuted to perform common post-action logic.
        /// E.g., exception handling, logging.
        /// </summary>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null && !context.ExceptionHandled)
            {
                _logger.LogError(context.Exception, "Unhandled exception in {Controller}.{Action}",
                    context.ActionDescriptor.RouteValues["controller"],
                    context.ActionDescriptor.RouteValues["action"]);

                context.Result = Failure("An unexpected error occurred.", 500);
                context.ExceptionHandled = true;
            }

            base.OnActionExecuted(context);
        }
    }

    /// <summary>
    /// Standard API response wrapper
    /// </summary>
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Error { get; set; }
    }
}


