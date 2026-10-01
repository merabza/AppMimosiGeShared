using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი გადახდა რედაქტირებისთვის. AcademicYearId კონტრაქტის სასწავლო წელია (ფორმის კონტრაქტების სიისთვის),
///     StudentContractName "გვარი სახელი ნომერი"
/// </summary>
public sealed record PaymentResponse(
    int Id,
    int StudentContractId,
    string StudentContractName,
    int AcademicYearId,
    DateTime PayDate,
    decimal Amount,
    string? Document,
    int? BankAccountId,
    bool Checked);
