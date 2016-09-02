using System;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts;
using Microsoft.AspNet.Identity;

namespace Advertise.ServiceLayer.EFServices
{
    public class SmsService : IIdentityMessageService,ISmsService
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your sms service here to send a text message.
            return Task.FromResult(0);
        }
    }
}