using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გაკვეთილების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset და სტრიქონები
/// </summary>
public sealed record LessonsRowsDataResponse(int AllRowsCount, int Offset, List<LessonRowResponse> Rows);
