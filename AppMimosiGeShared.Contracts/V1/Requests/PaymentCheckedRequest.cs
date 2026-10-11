namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     გადახდის "შემოწმებულია" ალმის დასმა ან მოხსნა პირდაპირ გადახდების სიიდან, რედაქტორის გახსნის გარეშე. სხვა ველები
///     არ იცვლება. მხოლოდ გადახდების შემოწმების უფლების მქონე როლს შეუძლია
/// </summary>
public sealed class PaymentCheckedRequest
{
    public bool Checked { get; init; }
}
