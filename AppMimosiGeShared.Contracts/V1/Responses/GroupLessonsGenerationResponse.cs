using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი ჯგუფის გაკვეთილების გენერაციის შედეგი (dry-run-ში გეგმა). UpdatedLessonsCount ითვლის გაკვეთილებს, რომელთა
///     ველები შეიცვალა; მოსწავლეების რაოდენობები არსებული გაკვეთილების მოსწავლეების სტრიქონებისაა.
///     DirtyStudentContractsCount: რამდენ კონტრაქტს დაენთო შემდეგი გადახდის თარიღის გადათვლის ალამი
/// </summary>
public sealed record GroupLessonsGenerationResponse(
    int GrpId,
    string GroupCode,
    int CreatedLessonsCount,
    int UpdatedLessonsCount,
    int DeletedLessonsCount,
    int AddedStudentsCount,
    int UpdatedStudentsCount,
    int DeletedStudentsCount,
    int DirtyStudentContractsCount,
    List<LessonGeneratorErrorResponse> Errors,
    List<LessonChangeResponse> Changes);
