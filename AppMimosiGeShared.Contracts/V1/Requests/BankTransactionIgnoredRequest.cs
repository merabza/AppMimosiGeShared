namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ჩარიცხვის მონიშვნა „არ არის მოსწავლის გადახდა“ (მაგ. დაბრუნება, სხვა შემოსავალი) ან მონიშვნის მოხსნა
/// </summary>
public sealed class BankTransactionIgnoredRequest
{
    public bool Ignored { get; init; }
}
