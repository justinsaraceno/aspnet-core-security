using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_security.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
