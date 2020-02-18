using System.Collections.Generic;
using System.Threading.Tasks;
using Managrr.Services.Radarr.Models;

namespace Managrr.Services.Radarr
{
    public interface IRadarrService
    {
        Task<IList<Quality>> GetQualities();

        Task<IList<RootFolder>> GetRootFolders();

        Task<IList<Movie>> GetMovies();
    }
}