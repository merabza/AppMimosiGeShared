using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     CRM ზარების სიის ფილტრისა და ზარის ფორმის ცნობარები: სასწავლო წლები (კონტრაქტების ასარჩევად;
///     CurrentAcademicYearId მიმდინარე წელია), ზარის ტიპები და შედეგები (სახელით, როგორც Access-ის ფორმაზე)
/// </summary>
public sealed record CrmCallFormLookupsResponse(
    int? CurrentAcademicYearId,
    List<LookupItemResponse> AcademicYears,
    List<LookupItemResponse> CallTypes,
    List<LookupItemResponse> AnswerTypes);
