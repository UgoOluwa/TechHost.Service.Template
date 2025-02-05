using FluentValidation;

namespace TechHost.Service.Template.Application.WeatherForecast.Queries.GetById;

public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
{
    public GetByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull();
    }
}
