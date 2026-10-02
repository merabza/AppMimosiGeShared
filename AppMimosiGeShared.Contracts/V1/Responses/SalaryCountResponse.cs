namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გამოთვლის შედეგი: შექმნილი ჩატარებული გაკვეთილების მდგენელები, სტრიქონები და დეტალები
/// </summary>
public sealed record SalaryCountResponse(int LessonPartsCount, int LinesCount, int DetailsCount);
