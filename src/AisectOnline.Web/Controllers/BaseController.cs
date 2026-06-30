
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;
using AisectOnline.Common.Users;
using AisectOnline.Common.Session;
using AisectOnline.Services.Modules.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
namespace AisectOnline.Web.Controllers
{
    /// <summary>
    /// Base controller providing common functionality for all MVC controllers.
    /// Automatically initializes session, handles logging, and provides user context.
    /// </summary>
    public abstract class BaseController : Controller
    {
        protected readonly ILogger<BaseController> _logger;
        protected readonly IUserContextService _userContext;
        protected readonly ISessionInitializer _sessionInit;

        protected BaseController(
            ILogger<BaseController> logger,
            IUserContextService userContext,
            ISessionInitializer sessionInit)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
            _sessionInit = sessionInit ?? throw new ArgumentNullException(nameof(sessionInit));
        }

        /// <summary>
        /// Gets the current user context (ID, Name, Email, Role).
        /// </summary>
        protected UserContextModel? CurrentUser => _userContext.GetUserContext();

        protected string CurrentUserId => CurrentUser?.UserId ?? string.Empty;
        protected string CurrentUserName => CurrentUser?.UserName ?? string.Empty;
        protected string CurrentUserEmail => CurrentUser?.Email ?? string.Empty;
        protected string CurrentUserRole => CurrentUser?.Role ?? string.Empty;

        /// <summary>
        /// Standard success response for AJAX or API calls.
        /// </summary>
        protected IActionResult Success<T>(T data) => Ok(new ApiResponse<T> { Success = true, Data = data });

        /// <summary>
        /// Standard failure response for AJAX or API calls.
        /// </summary>
        protected IActionResult Failure(string errorMessage, int statusCode = 400) =>
            StatusCode(statusCode, new ApiResponse<object> { Success = false, Error = errorMessage });

        /// <summary>
        /// Called before each action executes. Initializes session and logs the request.
        /// Skips user context logging for AllowAnonymous actions.
        /// </summary>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _sessionInit.InitializeSession(HttpContext);

            var controller = context.ActionDescriptor.RouteValues["controller"];
            var action = context.ActionDescriptor.RouteValues["action"];

            // Check for [AllowAnonymous] on action or controller
            bool isAllowAnonymous = context.Filters.Any(f =>
                f is AllowAnonymousFilter);

            if (!isAllowAnonymous && User?.Identity?.IsAuthenticated == true)
            {
                _logger.LogInformation("Executing {Controller}.{Action} for user {UserId}", controller, action, CurrentUserId);

                // Only enforce ModelState for authenticated actions
                if (!ModelState.IsValid)
                {
                    context.Result = Failure("Validation failed", 422);
                    return;
                }
            }
            else
            {
                _logger.LogInformation("Executing {Controller}.{Action} (anonymous or unauthenticated)", controller, action);
                // Do NOT enforce ModelState for AllowAnonymous actions (e.g., login)
            }

            base.OnActionExecuting(context);
        }


        /// <summary>
        /// Called after an action executes. Handles unhandled exceptions and logs them.
        /// </summary>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null && !context.ExceptionHandled)
            {
                var controller = context.ActionDescriptor.RouteValues["controller"];
                var action = context.ActionDescriptor.RouteValues["action"];
                _logger.LogError(context.Exception, "Unhandled exception in {Controller}.{Action}", controller, action);

                var env = context.HttpContext.RequestServices.GetService<IWebHostEnvironment>();
                var message = env != null && !env.IsProduction()
                    ? context.Exception.ToString()
                    : "An unexpected error occurred.";
                context.Result = Failure(message, 500);
                context.ExceptionHandled = true;
            }

            base.OnActionExecuted(context);
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
}


/*
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using AisectOnline.Common.Users;
using AisectOnline.Common.Session;
using AisectOnline.Services.Modules.Users;

namespace AisectOnline.Web.Controllers
{
    /// <summary>
    /// Base controller providing common functionality for all MVC controllers.
    /// Automatically initializes session, handles logging, and provides user context.
    /// </summary>
    public abstract class BaseController : Controller
    {
        protected readonly ILogger<BaseController> _logger;
        protected readonly IUserContextService _userContext;
        protected readonly ISessionInitializer _sessionInit;

        protected BaseController(
            ILogger<BaseController> logger,
            IUserContextService userContext,
            ISessionInitializer sessionInit)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
            _sessionInit = sessionInit ?? throw new ArgumentNullException(nameof(sessionInit));
        }

        /// <summary>
        /// Gets the current user context (ID, Name, Email, Role).
        /// </summary>
        protected UserContextModel? CurrentUser => _userContext.GetUserContext();

        protected string CurrentUserId => CurrentUser?.UserId ?? string.Empty;
        protected string CurrentUserName => CurrentUser?.UserName ?? string.Empty;
        protected string CurrentUserEmail => CurrentUser?.Email ?? string.Empty;
        protected string CurrentUserRole => CurrentUser?.Role ?? string.Empty;

        /// <summary>
        /// Standard success response for AJAX or API calls.
        /// </summary>
        protected IActionResult Success<T>(T data) => Ok(new ApiResponse<T> { Success = true, Data = data });

        /// <summary>
        /// Standard failure response for AJAX or API calls.
        /// </summary>
        protected IActionResult Failure(string errorMessage, int statusCode = 400) =>
            StatusCode(statusCode, new ApiResponse<object> { Success = false, Error = errorMessage });

        /// <summary>
        /// Called before each action executes. Initializes session and logs the request.
        /// </summary>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _sessionInit.InitializeSession(HttpContext);

            var controller = context.ActionDescriptor.RouteValues["controller"];
            var action = context.ActionDescriptor.RouteValues["action"];
            _logger.LogInformation("Executing {Controller}.{Action} for user {UserId}", controller, action, CurrentUserId);

            if (!ModelState.IsValid)
            {
                context.Result = Failure("Validation failed", 422);
                return;
            }

            base.OnActionExecuting(context);
        }

        /// <summary>
        /// Called after an action executes. Handles unhandled exceptions and logs them.
        /// </summary>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null && !context.ExceptionHandled)
            {
                var controller = context.ActionDescriptor.RouteValues["controller"];
                var action = context.ActionDescriptor.RouteValues["action"];
                _logger.LogError(context.Exception, "Unhandled exception in {Controller}.{Action}", controller, action);

                context.Result = Failure("An unexpected error occurred.", 500);
                context.ExceptionHandled = true;
            }

            base.OnActionExecuted(context);
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
}


//namespace AisectOnline.Web.Controllers;

//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.Extensions.Logging;
//using AisectOnline.Services.Modules.Users;
////using AisectOnline.Common.Services;
//using System;
//using AisectOnline.Common.Users;
//using Microsoft.AspNetCore.Authorization;


///// <summary>
///// Base controller providing common functionality for all MVC controllers.
///// Automatically initializes session, handles logging, and provides user context.
///// </summary>
////[Authorize]
//public abstract class BaseController : Controller
//{
//    protected readonly ILogger<BaseController> _logger;
//    protected readonly IUserContextService _userContext;
//    protected readonly ISessionInitializer _sessionInit;
//    protected BaseController() { }
//    protected BaseController(
//        ILogger<BaseController>? logger,
//        IUserContextService? userContext,
//        ISessionInitializer? sessionInit)
//    {
//        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
//        _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
//        _sessionInit = sessionInit ?? throw new ArgumentNullException(nameof(sessionInit));
//    }


//    protected string CurrentUserDetails()
//    {
//        var user = _userContext.GetUserContext();
//        if (user == null)
//            return "No user context available.";

//        return $"ID: {user.UserId}, Name: {user.UserName}, Email: {user.Email}, Role: {user.Role}";
//    }

//    protected UserContextModel? CurrentUser => _userContext.GetUserContext();

//    protected string CurrentUserId => CurrentUser?.UserId ?? string.Empty;
//    protected string CurrentUserName => CurrentUser?.UserName ?? string.Empty;
//    protected string CurrentUserEmail => CurrentUser?.Email ?? string.Empty;
//    protected string CurrentUserRole => CurrentUser?.Role ?? string.Empty;

//    /// <summary>
//    /// Gets current logged-in user's ID from claims.
//    /// </summary>
//    //protected string CurrentUserId => _userContext.GetUserId();

//    /// <summary>
//    /// Gets current logged-in user's email from claims.
//    /// </summary>
//    //protected string CurrentUserEmail => _userContext.GetUserEmail();

//    /// <summary>
//    /// Gets current logged-in user's roles.
//    /// </summary>
//    //protected IEnumerable<string> CurrentUserRoles => _userContext.GetUserRoles();

//    /// <summary>
//    /// Standard success response for AJAX or API calls.
//    /// </summary>
//    protected IActionResult Success<T>(T data) => Ok(new ApiResponse<T> { Success = true, Data = data });

//    /// <summary>
//    /// Standard failure response for AJAX or API calls.
//    /// </summary>
//    protected IActionResult Failure(string errorMessage, int statusCode = 400) =>
//        StatusCode(statusCode, new ApiResponse<object> { Success = false, Error = errorMessage });

//    /// <summary>
//    /// Called before each action executes. Initializes session and logs the request.
//    /// </summary>
//    public override void OnActionExecuting(ActionExecutingContext context)
//    {
//        // Initialize distributed session
//        _sessionInit.InitializeSession(HttpContext);

//        // Logging
//        var controller = context.ActionDescriptor.RouteValues["controller"];
//        var action = context.ActionDescriptor.RouteValues["action"];
//        _logger.LogInformation("Executing {Controller}.{Action} for user {UserId}", controller, action, CurrentUserId);

//        // Validate ModelState
//        if (!ModelState.IsValid)
//        {
//            context.Result = Failure("Validation failed", 422);
//            return;
//        }

//        base.OnActionExecuting(context);
//    }

//    /// <summary>
//    /// Called after an action executes. Handles unhandled exceptions and logs them.
//    /// </summary>
//    public override void OnActionExecuted(ActionExecutedContext context)
//    {
//        if (context.Exception != null && !context.ExceptionHandled)
//        {
//            var controller = context.ActionDescriptor.RouteValues["controller"];
//            var action = context.ActionDescriptor.RouteValues["action"];
//            _logger.LogError(context.Exception, "Unhandled exception in {Controller}.{Action}", controller, action);

//            context.Result = Failure("An unexpected error occurred.", 500);
//            context.ExceptionHandled = true;
//        }

//        base.OnActionExecuted(context);
//    }

//    /// <summary>
//    /// Standard API response wrapper
//    /// </summary>
//    public class ApiResponse<T>
//    {
//        public bool Success { get; set; }
//        public T Data { get; set; }
//        public string Error { get; set; }
//    }







//}

*/