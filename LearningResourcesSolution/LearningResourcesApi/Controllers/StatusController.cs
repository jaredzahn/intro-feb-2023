using LearningResourcesApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace LearningResourcesApi.Controllers;

public class StatusController : ControllerBase
{
    private ISystemTime _systemTime;

    public StatusController(ISystemTime systemTime)
    {
        _systemTime = systemTime;
    }

    [HttpGet("/status")]
    public ActionResult GetTheStatus()
    {
        var contact = _systemTime.GetCurrent().Hour < 16 ? "bob@aol.com" : "555-555-555";
        var response = new GetStatusResponse
        {
            Message = "all good",
            Contact = contact
        };
        return Ok(response);
    }
}

public class GetStatusResponse
{
    public string Message { get; set; } = string.Empty;

    public string Contact { get; set; } = string.Empty;
}