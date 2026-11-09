using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბანკიდან ჩარიცხვების მიღების შედეგი: პერიოდი, ბანკიდან მიღებული, უკვე არსებული, ახალი, მათგან ავტომატურად
///     განაწილებული და გაუნაწილებელი. DryRun: არაფერი შენახულა
/// </summary>
public sealed record ImportBankTransactionsResponse(
    DateTime PeriodFrom,
    DateTime PeriodTo,
    int Received,
    int AlreadyImported,
    int Imported,
    int Allocated,
    int Unallocated,
    bool DryRun);
