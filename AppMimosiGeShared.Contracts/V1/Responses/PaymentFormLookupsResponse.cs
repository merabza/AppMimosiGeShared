using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გადახდების სიის ფილტრისა და გადახდის ფორმის ცნობარები: სასწავლო წლები (კონტრაქტების ასარჩევად;
///     CurrentAcademicYearId მიმდინარე წელია) და გადახდის სახეები (ბანკები, სახელით, როგორც Access-ის ფორმაზე)
/// </summary>
public sealed record PaymentFormLookupsResponse(
    int? CurrentAcademicYearId,
    List<LookupItemResponse> AcademicYears,
    List<LookupItemResponse> BankAccounts);
