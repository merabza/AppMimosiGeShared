using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი გაკვეთილი ჟურნალისთვის. ჯგუფი, მასწავლებელი, დრო, სქემა, FourWeekHours და TeoMin/MaxDate მხოლოდ საჩვენებელია
///     (მათ გენერატორი ადგენს). PreviousLessonId/NextLessonId იმავე ჯგუფის წინა და შემდეგი გაკვეთილია (Access-ის
///     ფორმის "ძებნა"). მოსწავლეები სახელით ლაგდება
/// </summary>
public sealed record LessonResponse(
    int LessonId,
    int GrpId,
    string GroupCode,
    string CourseName,
    int TeacherContractId,
    string TeacherName,
    DateTime LessonDt,
    string SalarySchemeName,
    float FourWeekHours,
    DateTime TeoMinDate,
    DateTime TeoMaxDate,
    int LessonStatusId,
    int? SubstituteTeacherContractId,
    int TeacherLateMinutes,
    DateTime? RecoverDate,
    string? Note,
    int? PreviousLessonId,
    int? NextLessonId,
    List<LessonStudentResponse> Students);
