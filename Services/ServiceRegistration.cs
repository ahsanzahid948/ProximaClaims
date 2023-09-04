using Microsoft.AspNetCore.Identity;


namespace ProximaClaims.Services
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this WebApplicationBuilder applicationBuilder)
        {

           
            
            applicationBuilder.Services.AddHttpContextAccessor();
            applicationBuilder.Services.AddScoped<IHelper, Helper>();
            applicationBuilder.Services.AddScoped<IMailService, MailService>();

            applicationBuilder.Services.AddHttpContextAccessor();
            applicationBuilder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
