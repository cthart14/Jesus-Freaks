using JF_Services.Data.Context;
using JF_Services.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace JF_Services.Services;
public class LoginService
{
    private readonly JWTSettings _jwtSettings;
    private readonly JFDbContext _jfDbContext;

    public LoginService(IOptions<JWTSettings> jwtSettings, JFDbContext jfDbContext)
    {
        _jwtSettings = jwtSettings.Value;
        _jfDbContext = jfDbContext;
    }

    public async Task<string> LoginAsync(LoginDTO loginDTO)
    {
        if (loginDTO == null || loginDTO.USER_NAME == null || loginDTO.PASSWORD == null)
        {
            throw new ArgumentNullException("LoginDTO or its properties cannot be null.");
        }
        else
        {
            var username = loginDTO.USER_NAME;
            var password = loginDTO.PASSWORD;

            // async query to check if the user exists in the database
            var user = await _jfDbContext.Profiles.FirstOrDefaultAsync(u => u.USER_NAME == username && u.PASSWORD == password);
            return _jwtSettings.SecretKey;
        }
        
    }



}
