namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     სასწავლო წლის შემდეგი თავისუფალი კონტრაქტის ნომერი ("7.001"); null, თუ წლის პრეფიქსით 999-ვე ნომერი დაკავებულია
/// </summary>
public sealed record StudentContractNextNumberResponse(string? ContractNumber);
