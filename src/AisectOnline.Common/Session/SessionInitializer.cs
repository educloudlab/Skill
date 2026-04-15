namespace AisectOnline.Common.Users;
using Microsoft.AspNetCore.Http;
using System;

/// <summary>
/// Interface to initialize and manage session per request.
/// </summary>
public interface ISessionInitializer
{
    /// <summary>
    /// Ensures a session is initialized with default values if not already.
    /// </summary>
    /// <param name="context">HttpContext to initialize session on.</param>
    void InitializeSession(HttpContext context);
}

/// <summary>
/// Default implementation of <see cref="ISessionInitializer"/>.
/// Uses IDistributedCache-backed session.
/// </summary>
public class SessionInitializer : ISessionInitializer
{
    private const string InitializedKey = "SessionInitialized";
    private const string InitTimeKey = "SessionInitTime";

    public void InitializeSession(HttpContext context)
    {
        if (context == null) throw new ArgumentNullException(nameof(context));
        var session = context.Session;
        // Ensure session is loaded
        session.LoadAsync().GetAwaiter().GetResult();

        // If not initialized, set initial values
        if (string.IsNullOrEmpty(session.GetString(InitializedKey)))
        {
            session.SetString(InitializedKey, "true");
            session.SetString(InitTimeKey, DateTime.UtcNow.ToString("o"));
        }
    }
}