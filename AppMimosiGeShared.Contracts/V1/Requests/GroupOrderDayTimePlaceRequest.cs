using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ბრძანების განრიგის ხაზი: კვირის დღე, დაწყების დრო, საათები და ოთახი. Id 0 ახალ ხაზს ნიშნავს; შეცვლისას არსებული
///     ხაზი თავის Id-ს ინარჩუნებს. StartDate და EndDate მხოლოდ საწყის ბრძანებაშია
/// </summary>
public sealed class GroupOrderDayTimePlaceRequest
{
    public int Id { get; init; }
    public int WeekDayId { get; init; }
    public int LessonStartTimeId { get; init; }
    public float HoursCount { get; init; }
    public int RoomId { get; init; }
    public DateTime? StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}
