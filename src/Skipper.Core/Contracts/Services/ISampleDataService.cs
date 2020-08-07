using System.Collections.Generic;
using System.Threading.Tasks;

using Skipper.Core.Models;

namespace Skipper.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync();
    }
}
