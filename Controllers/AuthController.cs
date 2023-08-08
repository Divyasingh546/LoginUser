using LoginUser.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    // POST api/auth/login
    [HttpPost("login")]
    public ActionResult<string> Login([FromBody] UserCredentials userCredentials)
    {
        // In a real application, you would perform authentication here by checking user credentials against a database or external authentication service.

        // For demonstration purposes, we'll use a simple hard-coded check.
        // Replace this with your actual authentication logic.
        if (IsValidUser(userCredentials))
        {
            // Authentication successful
            return "Login successful.";
        }

        // Authentication failed
        return BadRequest("Invalid username or password.");
    }

    private bool IsValidUser(UserCredentials userCredentials)
    {
        // In a real application, you would validate the user credentials against a database or external authentication service.
        // For demonstration purposes, we'll use a hard-coded username and password.
        const string validUsername = "user123";
        const string validPassword = "password123";

        return userCredentials.Username == validUsername && userCredentials.Password == validPassword;
    }
}
