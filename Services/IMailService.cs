using ProximaClaims.HelperModels;
using ProximaClaims.Models;

namespace ProximaClaims.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(Contact mailRequest);

    }
}
