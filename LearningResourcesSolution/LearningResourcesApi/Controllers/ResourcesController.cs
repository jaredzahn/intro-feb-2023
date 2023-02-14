using LearningResourcesApi.Adapters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningResourcesApi.Controllers;

public class ResourcesController : ControllerBase
{
    private readonly LearningResourcesDataContext _context;

    public ResourcesController(LearningResourcesDataContext context)
    {
        _context = context;
    }

    [HttpGet("/resources")]
    public async Task<ActionResult> GetResources()
    {
        var response = await _context.Items.ToListAsync();
        return Ok(response);
    }


}
