using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    interface IResourceService
    {
        Task<List<Resource_V2>> GetResources();
        Task<Resource_V2> GetResourceById(int Id);
        Task<bool> SaveResource(Resource_V2 Resource);
        Task<bool> DeleteResource(string Id);
    }
}
