using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ჯგუფის განრიგის სტრიქონი: კვირის დღე, დაწყების დრო, საათები, ოთახი და პერიოდი [StartDate, EndDate).
///     Id 0 ახალ სტრიქონს ნიშნავს
/// </summary>
public sealed class GroupDayTimePlaceRequest
{
    public int Id { get; init; }
    public int WeekDayId { get; init; }
    public int LessonStartTimeId { get; init; }
    public float HoursCount { get; init; }
    public int RoomId { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}
