using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class ProblemService : IProblemService
     {
          public List<Problem_V2> Problems { get; set; }

          public ProblemService()
          {
               //throw new Exception("ProblemServiceException");

               Problems = new List<Problem_V2>();

               Problems.Add(new Problem_V2(1, "Title", "Solution", "SolutionLink", "Details", DateTime.Now, DateTime.Now));
          }

          public async Task<List<Problem_V2>> GetProblems()
          {
               return await Task.FromResult(Problems);
          }

          public async Task<Problem_V2> GetProblemById(int ProblemId)
          {
               return await Task.FromResult(Problems.Where(auth => auth.Id == ProblemId).FirstOrDefault());
          }

          public async Task<bool> SaveProblem(Problem_V2 Problem)
          {
               //Problem.ProblemId = GetNewProblem();
               Problems.Add(Problem);
               return await Task.FromResult(true);
          }

          private string GetNewProblem()
          {
               string id;
               Random random = new Random();
               id = random.Next(100, 1000).ToString() + "-";
               id += random.Next(10, 100).ToString() + "-";
               id += random.Next(1000, 10000).ToString();

               return id;
          }

          public async Task<bool> DeleteProblem(string ProblemId)
          {
               return await Task.FromResult(true);
          }
     }
}
