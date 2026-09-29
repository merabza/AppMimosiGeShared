namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     კონტრაქტის დეტალი (ტარიფი). Id 0 ახალ დეტალს ნიშნავს
/// </summary>
public sealed class StudentContractDetailRequest
{
    public int Id { get; init; }
    public int CourseId { get; init; }
    public int GroupSizeId { get; init; }
    public float FourWeekHours { get; init; }
    public decimal FourWeekFee { get; init; }
    public decimal OneHourFee { get; init; }
}
