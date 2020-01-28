using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;

namespace StatCan.OrchardCore.GCCollab.Configuration
{
    public class GCCollabOptions : OAuthOptions
    {
        public GCCollabOptions()
        {
            CallbackPath = new PathString("/signin-gccollab");
            AuthorizationEndpoint = GCCollabDefaults.AuthorizationEndpoint;
            TokenEndpoint = GCCollabDefaults.TokenEndpoint;
            UserInformationEndpoint = GCCollabDefaults.UserInformationEndpoint;

            // todo: Map Additional claims here
            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "sub");
            ClaimActions.MapJsonKey("name", "name");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email", ClaimValueTypes.Email);
            ClaimActions.MapJsonKey("url", "url");
        }
    }
}