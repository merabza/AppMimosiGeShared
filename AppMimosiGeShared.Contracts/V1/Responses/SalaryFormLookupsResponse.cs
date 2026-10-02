using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     უწყისის ფორმის ცნობარები: თანამშრომლები (ყველა კონტრაქტი, "გვარი სახელი / ნომერი") და მდგენელების ტიპები
/// </summary>
public sealed record SalaryFormLookupsResponse(
    List<LookupItemResponse> Employees,
    List<SalaryPartTypeLookupResponse> PartTypes);

/// <summary>
///     მდგენელის ტიპი. CountPlaceId: 1 = დანამატი, 2 = გამოქვითვა ხელზე ასაღებიდან, ცარიელი = გამოთვლაში არ მონაწილეობს
/// </summary>
public sealed record SalaryPartTypeLookupResponse(int Id, string Name, int? CountPlaceId);
