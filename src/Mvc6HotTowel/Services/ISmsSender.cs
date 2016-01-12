using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc6HotTowel.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
