namespace StatCan.OrchardCore.GCCollab.Configuration
{
    public static class GCCollabDefaults
    {
        public const string AuthenticationScheme = "GCCollab";
        public static readonly string DisplayName = "GCCollab";
        public static readonly string AuthorizationEndpoint = "https://account.gccollab.ca/openid/authorize";
        public static readonly string TokenEndpoint = "https://account.gccollab.ca/openid/token";
        public static readonly string UserInformationEndpoint = "https://account.gccollab.ca/openid/userinfo";
    }
}
