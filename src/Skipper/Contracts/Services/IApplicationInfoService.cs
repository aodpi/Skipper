using System;

namespace Skipper.Contracts.Services
{
    public interface IApplicationInfoService
    {
        Version GetVersion();
    }
}
