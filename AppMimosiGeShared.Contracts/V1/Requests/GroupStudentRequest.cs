using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ჯგუფის მოსწავლე (კონტრაქტი) ტარიფით და პერიოდით [StartDate, EndDate). Id 0 ახალ სტრიქონს ნიშნავს
/// </summary>
public sealed class GroupStudentRequest
{
    public int Id { get; init; }
    public int StudentContractId { get; init; }
    public float FourWeekHours { get; init; }
    public decimal FourWeekFee { get; init; }
    public decimal OneHourFee { get; init; }
    public float HoursCoefficient { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
    public string? Note { get; init; }
}
