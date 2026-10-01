using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ამონაწერისა და ბალანსების გვერდების ცნობარები: სასწავლო წლები (კონტრაქტის ასარჩევად და ბალანსების ფილტრისთვის)
///     და მიმდინარე წელი
/// </summary>
public sealed record BalancesFormLookupsResponse(int? CurrentAcademicYearId, List<LookupItemResponse> AcademicYears);
