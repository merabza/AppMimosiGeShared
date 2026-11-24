using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ვიზარდი 1-ის, „ბრძანებებზე გადასვლის", შედეგი (D194); dry-run-ში შემოწმების რეპორტი. TransitionDate: გადასვლის
///     დღე (D0). Violations: დარღვევები; თუ ერთი მაინც არის, არაფერი იცვლება და Switched = false, ნამდვილ გაშვებაზეც,
///     რომელიც ყველაფერს ხელახლა ამოწმებს (D219). Groups: ყოველი ჯგუფი საწყისი ბრძანების თარიღით (D196); დარღვევები ამ
///     სიას არ ცვლის
/// </summary>
public sealed record SwitchToGroupOrdersResponse(
    bool DryRun,
    bool Switched,
    DateTime TransitionDate,
    List<GroupOrdersSwitchViolationResponse> Violations,
    List<GroupOrdersSwitchGroupResponse> Groups);
