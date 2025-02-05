using TechHost.Service.Template.Application.Commons.Bases;

namespace TechHost.Service.Template.Application.Commons.Exceptions;

public class ValidationException : Exception
{
    public IEnumerable<BaseError> Errors { get; }

    public ValidationException()
        : base("One or more validation failures have occured.")
    {
        Errors = new List<BaseError>();
    }

    public ValidationException(IEnumerable<BaseError> errors)
        : this()
    {
        Errors = errors;
    }
}
