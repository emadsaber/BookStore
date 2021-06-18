using System.Text.Json.Serialization;

namespace BookStore.Models.DTOs.Users
{
    public class AuthUserDto
    {
        [JsonPropertyName("sub")]
        public string AuthUserId { get; set; }
        
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("picture")]
        public string PictureUrl { get; set; }

        [JsonPropertyName("email_verified")]
        public bool EmailVerified { get; set; }
    }
}
