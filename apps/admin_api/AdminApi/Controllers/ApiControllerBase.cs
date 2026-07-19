using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Rubencho.AdminApi.Controllers;

/// <summary>
/// ApiControllerBase class
/// </summary>
[ApiController]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    private ISender mediator = null!;

    /// <summary>
    /// Requests ISender HttpContext Services
    /// </summary>
    protected ISender Mediator => mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}