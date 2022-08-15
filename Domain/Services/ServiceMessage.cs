using Domain.Interface;
using Domain.Interface.InterfaceService;

namespace Domain.Services
{
    public class ServiceMessage : IServiceMessege
    {
        private readonly IMessage _IMessage;

        public ServiceMessage(IMessage IMessage)
        {
            _IMessage = IMessage;
        }
    }
}
