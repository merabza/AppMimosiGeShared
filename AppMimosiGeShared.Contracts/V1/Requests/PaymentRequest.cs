using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     მოსწავლის კონტრაქტზე გადახდის შექმნის ან შეცვლის მოთხოვნა. თანხა შეიძლება უარყოფითი იყოს (მაგ. "გადატანა"
///     კონტრაქტებს შორის). BankAccountId გადახდის სახეა (ბანკი ან სპეციალური სახე). Checked-ს ცვლის მხოლოდ გადახდების
///     შემოწმების უფლების მქონე როლი
/// </summary>
public sealed class PaymentRequest
{
    public int StudentContractId { get; init; }
    public DateTime PayDate { get; init; }
    public decimal Amount { get; init; }
    public string? Document { get; init; }
    public int? BankAccountId { get; init; }
    public bool Checked { get; init; }
}
