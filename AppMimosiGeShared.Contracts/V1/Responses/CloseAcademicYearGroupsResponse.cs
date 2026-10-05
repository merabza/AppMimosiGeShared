using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     სასწავლო წლის ჯგუფების დახურვის შედეგი (dry-run-ში გეგმა). Groups: ჯგუფები, რომლებსაც VoidDate = CloseDate დაესვა
///     (დაესმება); უკვე დახურული ჯგუფები აქ არ არის, ამიტომ განმეორებითი გაშვება ცარიელ სიას აბრუნებს
/// </summary>
public sealed record CloseAcademicYearGroupsResponse(
    bool DryRun,
    int AcademicYearId,
    DateTime CloseDate,
    DateTime HorizonEnd,
    List<CloseGroupResponse> Groups);
