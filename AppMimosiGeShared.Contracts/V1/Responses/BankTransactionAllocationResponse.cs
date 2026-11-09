namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჩარიცხვის განაწილების ერთი გადახდა. StudentContractName "გვარი სახელი ნომერი", AcademicYearId კონტრაქტის წელი
/// </summary>
public sealed record BankTransactionAllocationResponse(
    int PaymentId,
    int StudentContractId,
    string StudentContractName,
    int AcademicYearId,
    decimal Amount,
    bool Checked);
