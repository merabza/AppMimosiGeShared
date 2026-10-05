using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     სასწავლო წლები (დაწყების რიგით) და მიმდინარე წელი: front-ის გლობალური წლის ამომრჩევისთვის (ნაწილი 20)
/// </summary>
public sealed record AcademicYearsResponse(List<LookupItemResponse> AcademicYears, int? CurrentAcademicYearId);
