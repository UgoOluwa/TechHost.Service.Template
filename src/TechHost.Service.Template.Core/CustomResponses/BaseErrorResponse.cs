using FluentValidation.Results;

namespace TechHost.Service.Template.Core.CustomResponses;

public class BaseErrorResponse<T>
{
    public BaseErrorResponse(List<ValidationFailure> error, string statusCode, string message)
    {
        StatusCode = statusCode;
        Message = message;
        Error = GetErrors(error);
    }
    public string StatusCode { get; set; }
    public string Message { get; set; }
    public string Error { get; set; }


    private string GetErrors(List<ValidationFailure> error)
    {
        var errorList = error.Select(x => $"{x.ErrorMessage}").ToList();
        return string.Join(", ", errorList);
    }
}
