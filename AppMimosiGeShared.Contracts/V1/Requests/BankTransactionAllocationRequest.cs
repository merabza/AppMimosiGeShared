using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ბანკის ჩარიცხვის ხელით განაწილება (D164): წილები მოსწავლეების კონტრაქტებზე. წილების ჯამი ჩარიცხულს ვერ
///     აღემატება, ნაკლები შეიძლება იყოს; ცარიელი სია განაწილებას შლის
/// </summary>
public sealed class BankTransactionAllocationRequest
{
    public List<BankTransactionShareRequest> Shares { get; init; } = [];
}
