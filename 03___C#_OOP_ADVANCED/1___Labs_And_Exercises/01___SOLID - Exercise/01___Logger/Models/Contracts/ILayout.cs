using _01.Logger.Models.Contracts;

namespace _01.Logger.Models.Contracts
{
    public interface ILayout
    {
        string FormatError(IError error);
    }
}