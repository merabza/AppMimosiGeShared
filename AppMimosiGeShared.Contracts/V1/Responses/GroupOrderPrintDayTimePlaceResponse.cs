namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     განრიგის სტრიქონი ბრძანების ბეჭდვისთვის. LessonStartTime: „HH:mm"
/// </summary>
public sealed record GroupOrderPrintDayTimePlaceResponse(
    string WeekDayName,
    string LessonStartTime,
    float HoursCount,
    string RoomName);
