using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბრძანების განრიგის ხაზი. StartDate და EndDate მხოლოდ საწყის ბრძანებას აქვს
/// </summary>
public sealed record GroupOrderDayTimePlaceResponse(
    int Id,
    int WeekDayId,
    int LessonStartTimeId,
    float HoursCount,
    int RoomId,
    DateTime? StartDate,
    DateTime? EndDate);
