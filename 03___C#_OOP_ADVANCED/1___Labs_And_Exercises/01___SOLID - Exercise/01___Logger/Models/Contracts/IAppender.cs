using _01.Logger.Models.Contracts;

namespace _01.Logger.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        ErrorLevel Level { get; }

        void Append(IError error);
    }
}
