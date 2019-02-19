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
            Random rand = new Random();
            int id = rand.Next(1, await _questionRepository.GetQuestionsCount());

            Question question = await _questionRepository.GetQuestionbyIdAsync(id);

            return question;
        }

    }
}
