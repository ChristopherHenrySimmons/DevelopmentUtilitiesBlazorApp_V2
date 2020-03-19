using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    interface IProblemService
    {
        Task<List<Problem_V2>> GetProblems();
        Task<Problem_V2> GetProblemById(int Id);
        Task<bool> SaveProblem(Problem_V2 Problem);
        Task<bool> DeleteProblem(string Id);
    }
}
