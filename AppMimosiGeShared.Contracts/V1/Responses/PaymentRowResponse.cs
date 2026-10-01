using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გადახდების სიის ერთი სტრიქონი. StudentName "გვარი სახელი ნომერი"-ა (კონტრაქტის ნომრით), როგორც Access-ის ფორმაზე.
///     BankName გადახდის სახის სახელია
/// </summary>
public sealed record PaymentRowResponse(
    int Id,
    int StudentContractId,
    string StudentName,
    DateTime PayDate,
    decimal Amount,
    string? Document,
    int? BankAccountId,
    string? BankName,
    bool Checked);
