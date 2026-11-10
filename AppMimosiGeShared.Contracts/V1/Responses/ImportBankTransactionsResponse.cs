using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბანკიდან ჩარიცხვების მიღების შედეგი, თითო ინტეგრირებულ ანგარიშზე (D173). DryRun: არაფერი შენახულა
/// </summary>
public sealed record ImportBankTransactionsResponse(List<ImportBankAccountResponse> Accounts, bool DryRun);

/// <summary>
///     ერთი ანგარიშის მიღება: პერიოდი, ბანკიდან მიღებული, უკვე არსებული, ახალი, მათგან ავტომატურად განაწილებული და
///     გაუნაწილებელი. Error: ამ ანგარიშის მიღება ვერ შედგა (მაგ. ბანკის ლიმიტი), სხვა ანგარიშებს ეს არ აჩერებს
/// </summary>
public sealed record ImportBankAccountResponse(
    int BankAccountId,
    string BankName,
    DateTime PeriodFrom,
    DateTime PeriodTo,
    int Received,
    int AlreadyImported,
    int Imported,
    int Allocated,
    int Unallocated,
    string? Error);
