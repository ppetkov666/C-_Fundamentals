using System;

namespace _01.Logger.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }
        ErrorLevel Level { get; }
    }
}