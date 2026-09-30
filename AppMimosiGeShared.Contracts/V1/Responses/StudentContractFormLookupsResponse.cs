using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     კონტრაქტის ფორმისა და სიის ფილტრის ცნობარები. CurrentAcademicYearId მიმდინარე სასწავლო წელია
///     (დღევანდელი თარიღი მის ფარგლებშია, ან ბოლო დაწყებული წელი)
/// </summary>
public sealed record StudentContractFormLookupsResponse(
    int? CurrentAcademicYearId,
    List<LookupItemResponse> AcademicYears,
    List<LookupItemResponse> StudentStatuses,
    List<LookupItemResponse> Courses,
    List<LookupItemResponse> GroupSizes);
