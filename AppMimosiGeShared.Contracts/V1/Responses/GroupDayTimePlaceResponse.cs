using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

public sealed record GroupDayTimePlaceResponse(
    int Id,
    int WeekDayId,
    int LessonStartTimeId,
    float HoursCount,
    int RoomId,
    DateTime StartDate,
    DateTime? EndDate);
