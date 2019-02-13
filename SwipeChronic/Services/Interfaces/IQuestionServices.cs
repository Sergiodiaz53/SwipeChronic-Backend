using SwipeChronic.Models;
using System;
using System.Threading.Tasks;

namespace SwipeChronic.Services.Interfaces
{
    public interface IQuestionServices
    {
        Task Register(Question question);
    }
}
