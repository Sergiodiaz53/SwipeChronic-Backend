using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SwipeChronic.Models;

namespace SwipeChronic.Infrastructure.Interfaces
{
    public interface IQuestionRepository : IDisposable
    {
        Task<Question> GetQuestionbyIdAsync(int id);
        Task CreateQuestionAsync(Question question);
        Task DeleteQuestionById(int id);
        Task<Question> GetRandomQuestion();
        Task<int> SaveChangesAsync();
    }
}