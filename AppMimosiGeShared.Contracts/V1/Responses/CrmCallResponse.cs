using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი CRM ზარი რედაქტირებისთვის. AcademicYearId კონტრაქტის სასწავლო წელია (ფორმის კონტრაქტების სიისთვის),
///     StudentContractName "გვარი სახელი / ნომერი"
/// </summary>
public sealed record CrmCallResponse(
    int Id,
    int StudentContractId,
    string StudentContractName,
    int AcademicYearId,
    int CallTypeId,
    DateTime CallDate,
    int AnswerTypeId,
    string? CallConversation,
    DateTime? MustPayDate);
