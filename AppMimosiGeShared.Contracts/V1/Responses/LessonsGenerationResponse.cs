using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გაკვეთილების გენერაციის შედეგი (ერთი, dirty ან ყველა ჯგუფი). DryRun-ში ბაზაში არაფერი იწერება და Groups გეგმაა.
///     HorizonEnd: ბოლო სამუშაო თვის ბოლო დღე, რომლამდეც გაკვეთილები იქმნება. AddedOperationMonthsCount: რამდენი სამუშაო
///     თვე დაემატა (dry-run-ში დაემატებოდა); ახალი თვე ყველა ჯგუფს და კონტრაქტს dirty-ს ხდის
/// </summary>
public sealed record LessonsGenerationResponse(
    bool DryRun,
    DateTime HorizonEnd,
    int AddedOperationMonthsCount,
    List<GroupLessonsGenerationResponse> Groups);
