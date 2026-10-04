using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     უწყისის ფორმის ცნობარები: თანამშრომლები (ყველა კონტრაქტი, "გვარი სახელი / ნომერი") და მდგენელების ტიპები
/// </summary>
public sealed record SalaryFormLookupsResponse(
    List<LookupItemResponse> Employees,
    List<SalaryPartTypeLookupResponse> PartTypes);
