namespace Cyber_Cougars.Models;

/// <summary>
/// The viewmodel that displays the error page.
/// </summary>
public class ErrorViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public string? RequestId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}