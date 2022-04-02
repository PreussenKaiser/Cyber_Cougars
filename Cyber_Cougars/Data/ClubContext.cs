using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cyber_Cougars.Data;

/// <summary>
/// The database context to query club activities with.
/// </summary>
public class ClubContext : IdentityDbContext
{
    /// <summary>
    /// Initializes a new instance of the ClubContext database context.
    /// </summary>
    /// <param name="options">The options for the database context.</param>
    public ClubContext(DbContextOptions<ClubContext> options)
        : base(options)
    {
    }
}