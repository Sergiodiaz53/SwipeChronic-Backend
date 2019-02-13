using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SwipeChronic.Models;

namespace SwipeChronic.Infrastructure.Interfaces
{
    public interface IQuestionRepository : IDisposable
    {
        IEnumerable<Question> GetQuestions();
        Question GetRandomQuestion();
        Task InsertQuestion(Question question);
        Task DeleteQuestion(int questionID);
        Task Save();
    }
}