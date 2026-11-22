using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ბრძანების მოსწავლის ხაზი. Id 0 ახალ ხაზს ნიშნავს; შეცვლისას არსებული ხაზი თავის Id-ს ინარჩუნებს, რომ მისმა
///     სტრიქონმაც შეინარჩუნოს. ტარიფი (კოეფიციენტი, საათის ფასი, 4 კვირის გადასახადი) გაყვანის ბრძანებაში (4) ცარიელია.
///     4 კვირის საათებს სერვერი ფორმულით ითვლის (D187), ამიტომ FourWeekHours, StartDate და EndDate მხოლოდ საწყის
///     ბრძანებაშია
/// </summary>
public sealed class GroupOrderStudentRequest
{
    public int Id { get; init; }
    public int StudentContractId { get; init; }
    public float? FourWeekHours { get; init; }
    public decimal? FourWeekFee { get; init; }
    public decimal? OneHourFee { get; init; }
    public float? HoursCoefficient { get; init; }
    public string? Note { get; init; }
    public DateTime? StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}
