namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     მდგენელის ტიპი. CountPlaceId: 1 = დანამატი, 2 = გამოქვითვა ხელზე ასაღებიდან, ცარიელი = გამოთვლაში არ მონაწილეობს
/// </summary>
public sealed record SalaryPartTypeLookupResponse(int Id, string Name, int? CountPlaceId);
