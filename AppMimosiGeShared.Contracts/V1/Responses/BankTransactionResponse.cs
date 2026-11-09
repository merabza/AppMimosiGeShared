using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი ჩარიცხვა ბანკის ველებით და განაწილებით (გადახდები)
/// </summary>
public sealed record BankTransactionResponse(
    int Id,
    DateTime TransactionDate,
    decimal Amount,
    string Currency,
    string? Purpose,
    string? AdditionalInformation,
    string? AdditionalDescription,
    string? DocumentNumber,
    string? PartnerName,
    string? PartnerAccountIban,
    string? PartnerTaxCode,
    int MatchStep,
    bool AllocatedManually,
    bool Ignored,
    List<BankTransactionAllocationResponse> Allocations);
