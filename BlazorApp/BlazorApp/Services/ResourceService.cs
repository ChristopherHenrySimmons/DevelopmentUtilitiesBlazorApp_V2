using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class ResourceService : IResourceService
     {
          public List<Resource_V2> Resources { get; set; }

          public ResourceService()
          {
               //throw new Exception("ResourceServiceException");

               Resources = new List<Resource_V2>();

               Resources.Add(new Resource_V2(1, "Title", "Description", "Link", "Langues", DateTime.Now, DateTime.Now));
          }

          public async Task<List<Resource_V2>> GetResources()
          {
               return await Task.FromResult(Resources);
          }

          public async Task<Resource_V2> GetResourceById(int ResourceId)
          {
               return await Task.FromResult(Resources.Where(auth => auth.Id == ResourceId).FirstOrDefault());
          }

          public async Task<bool> SaveResource(Resource_V2 Resource)
          {
               //Resource.ResourceId = GetNewResource();
               Resources.Add(Resource);
               return await Task.FromResult(true);
          }

          private string GetNewResource()
          {
               string id;
               Random random = new Random();
               id = random.Next(100, 1000).ToString() + "-";
               id += random.Next(10, 100).ToString() + "-";
               id += random.Next(1000, 10000).ToString();

               return id;
          }

          public async Task<bool> DeleteResource(string ResourceId)
          {
               return await Task.FromResult(true);
          }
     }
}
