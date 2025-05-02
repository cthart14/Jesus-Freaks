using System;

namespace JF_Services.Models.DTOs;


public class JWTSettings
{
    public required string SecretKey { get; set; }
    public required string Issuer { get; set; }
    public required string Audience { get; set; }
    public int ExpireDuration { get; set; }
}


