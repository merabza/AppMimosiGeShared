using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი ჯგუფი რედაქტირებისთვის. DirtyLessons მხოლოდ საჩვენებელია.
///     მასწავლებლები და განრიგი დაწყების თარიღით ლაგდება, მოსწავლეები სახელით, დაწყებით და დასრულებით (Access-ის ფორმები)
/// </summary>
public sealed record GroupResponse(
    int GrpId,
    int AcademicYearId,
    string GroupCode,
    int CourseId,
    int GroupSizeId,
    int StudentStatusId,
    DateTime? VoidDate,
    bool DirtyLessons,
    List<GroupTeacherResponse> Teachers,
    List<GroupStudentResponse> Students,
    List<GroupDayTimePlaceResponse> DayTimePlaces);
