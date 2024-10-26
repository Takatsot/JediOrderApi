using JediOrderApi.Models.DTO;
using JediOrderApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace JediOrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITokenRepository _tokenRepository;
        private readonly ILogger<AuthController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class with the specified account manager.
        /// </summary>
        /// <param name="accountManager">The account manager.</param>
        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository, ILogger<AuthController> logger)
        {
            _userManager = userManager;
            _tokenRepository = tokenRepository;
            _logger = logger;
        }

        /// <summary>
		/// Creates a new user account.
		/// </summary>
		/// <param name="registerRequest">The user details for the account creation.</param>
		[HttpPost, AllowAnonymous]
        [Route("Register")]
        public async Task<ActionResult> Register([FromBody] RegisterRequestDto registerRequest)
        {
            _logger.LogInformation("Attempting to register user: {UserName}", registerRequest.Name);

            var identityUser = new IdentityUser
            {
                UserName = registerRequest.Name,
                Email = registerRequest.Email,
            };

            var identityResult = await _userManager.CreateAsync(identityUser, registerRequest.Password);

            if (identityResult.Succeeded)
            {
                if (registerRequest.Roles != null && registerRequest.Roles.Any())
                {
                    identityResult = await _userManager.AddToRolesAsync(identityUser, registerRequest.Roles);

                    if (identityResult.Succeeded)
                    {
                        _logger.LogInformation("User '{UserName}' registered successfully with roles: {Roles}", identityUser.UserName, string.Join(", ", registerRequest.Roles));
                        return Ok("User Registered! Please login.");
                    }
                    else
                    {
                        _logger.LogWarning("User '{UserName}' created but failed to assign roles. Errors: {Errors}", identityUser.UserName, string.Join(", ", identityResult.Errors.Select(e => e.Description)));
                    }
                }
                else
                {
                    _logger.LogInformation("User '{UserName}' registered without roles.", identityUser.UserName);
                }
            }
            else
            {
                _logger.LogError("Registration failed for user '{UserName}'. Errors: {Errors}", identityUser.UserName, string.Join(", ", identityResult.Errors.Select(e => e.Description)));
                return BadRequest("Oops, something went wrong during registration.");
            }

            return BadRequest("Oops, something went wrong.");
        }

        /// <summary>
		/// Creates a new user account.
		/// </summary>
		/// <param name="loginRequestDto">The user details for the account creation.</param>
        [HttpPost, AllowAnonymous]
        [Route("Login")]
        public async Task<ActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
             var user = await _userManager.FindByEmailAsync(loginRequestDto.Username);

            if (user != null) 
            {
                bool checkPasswordResult = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);

                if (checkPasswordResult)
                {
                    IList<string> roles = await _userManager.GetRolesAsync(user);

                    if(roles != null && roles.Any())
                    {
                       string jwtSecurityToken = _tokenRepository.CreateJWTToken(user, roles.ToList());
                        LoginResponse response = new LoginResponse
                        {
                            JwtToken = jwtSecurityToken,
                        };

                        return Ok(response);
                    }                  
                }
            }
            
            return BadRequest("Username or Password Incorrect");
        }
    }
}
