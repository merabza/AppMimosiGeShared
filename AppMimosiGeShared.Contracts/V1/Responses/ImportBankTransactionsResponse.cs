using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბანკიდან ჩარიცხვების მიღების შედეგი, თითო ინტეგრირებულ ანგარიშზე (D173). DryRun: არაფერი შენახულა
/// </summary>
public sealed record ImportBankTransactionsResponse(List<ImportBankAccountResponse> Accounts, bool DryRun);
