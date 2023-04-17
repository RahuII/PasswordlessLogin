using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Identity;

namespace tokenAuth.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ActiveUser : ControllerBase
{
    private readonly IIdentityUserRepository _userRepository;

    public ActiveUser(IIdentityUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _userRepository.GetListAsync();
        var activeUsers = users.Where(u => u.IsActive);
        return Ok(activeUsers);
    }

    [HttpGet("percentage")]
    public async Task<IActionResult> GetPercentageOfActiveUsers()
    {
        var users = await _userRepository.GetListAsync();
        var activeUsers = users.Where(u => u.IsActive);
        var percentage = (double)activeUsers.Count() / users.Count() * 100;
        return Ok(string.Format("{0:F2}", percentage));
    }
}
