using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჩარიცხვების სიის სტრიქონი. MatchStep: რომელმა წესმა იპოვა მოსწავლე (0 = ვერ იპოვა, TBC_INTEGRATION.md §4);
///     AllocatedAmount: გადახდებად განაწილებული ჯამი; HasCheckedPayments: განაწილების რომელიმე გადახდა შემოწმებულია
///     (განაწილება აღარ იცვლება, D168)
/// </summary>
public sealed record BankTransactionRowResponse(
    int Id,
    DateTime TransactionDate,
    decimal Amount,
    string? PartnerName,
    string? Purpose,
    int MatchStep,
    bool AllocatedManually,
    bool Ignored,
    decimal AllocatedAmount,
    bool HasCheckedPayments);
