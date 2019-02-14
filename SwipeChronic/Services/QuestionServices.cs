using System;
using System.Threading.Tasks;
using SwipeChronic.Infrastructure.Interfaces;
using SwipeChronic.Models;
using SwipeChronic.Services.Interfaces;

namespace SwipeChronic.Services
{
    public class QuestionServices : IQuestionServices
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionServices(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task Register(Question question)
        {
            await _questionRepository.CreateQuestionAsync(question);
            await _questionRepository.SaveChangesAsync();
        }

        public async Task<Question> GetRandomQuestion()
        {
            return await _questionRepository.GetRandomQuestion();
        }

    }
}
