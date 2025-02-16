﻿namespace DotNet8.HangfireApi.Features;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    #region Content

    protected IActionResult Content(object obj)
    {
        return Content(JsonConvert.SerializeObject(obj), "application/json");
    }

    #endregion

}
