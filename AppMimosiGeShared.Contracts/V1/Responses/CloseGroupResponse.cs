using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     დასახურავი ჯგუფი: ძველი VoidDate, დაუსრულებელი სტრიქონები (მასწავლებელი, მოსწავლე, განრიგი), დახურვის თარიღის
///     შემდგომი წასაშლელი გაკვეთილების დარიცხვის ჯამი (უარყოფითი თანხა, როგორც ამონაწერში) და გენერატორის შედეგი (dry-run-ში
///     გეგმა)
/// </summary>
public sealed record CloseGroupResponse(
    int GrpId,
    string GroupCode,
    string CourseName,
    DateTime? PreviousVoidDate,
    int OpenTeacherRowsCount,
    int OpenStudentRowsCount,
    int OpenScheduleRowsCount,
    decimal DeletedLessonsCharges,
    GroupLessonsGenerationResponse Generation);
