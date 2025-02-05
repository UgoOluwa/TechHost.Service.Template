﻿namespace TechHost.Service.Template.Application.Commons.Bases;

public class BaseResponse<T>(bool isSuccessful, T? data, string? message, IEnumerable<BaseError>? errors) : BaseReponseGeneric<T>(isSuccessful, data, message, errors)
{
}