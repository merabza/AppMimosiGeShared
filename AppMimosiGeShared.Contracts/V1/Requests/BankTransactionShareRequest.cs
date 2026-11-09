namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ჩარიცხვის ერთი წილი: მოსწავლის კონტრაქტი და დადებითი თანხა (2 ათწილადამდე)
/// </summary>
public sealed class BankTransactionShareRequest
{
    public int StudentContractId { get; init; }
    public decimal Amount { get; init; }
}
