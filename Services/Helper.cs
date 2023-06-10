namespace ProximaClaims.Services
{

    public interface IHelper 
    {
        public string ProjectName();
        public string Version();
        public string WebLink();
        
        public string GetProjectInfo(string name);
    }
    public class Helper:IHelper
    {
        private IConfiguration _configuration;
        IHttpContextAccessor _httpContextAccessor;
        public Helper(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }
        public string ProjectName()
        {
            return _configuration.GetSection("Project").GetSection("Name").Value;
        }
        public string Version()
        {
            return _configuration.GetSection("Project").GetSection("Version").Value;
        }
        public string WebLink()
        {
            return _configuration.GetSection("Project").GetSection("WebLink").Value;
        }
        public string GetProjectInfo(string name)
        {
            return _configuration.GetSection("Project").GetSection(name).Value;
        }
       
    }
}
