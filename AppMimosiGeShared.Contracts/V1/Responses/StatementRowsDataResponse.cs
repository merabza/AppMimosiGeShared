using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ამონაწერის ერთი გვერდი: ფილტრის ოპერაციების რაოდენობა, რეალური offset, საწყისი ნაშთი (ოპერაციები "თარიღიდან"-მდე),
///     საბოლოო ნაშთი (ოპერაციები "თარიღამდე" ჩათვლით, მის გარეშე ყველა) და სტრიქონები
/// </summary>
public sealed record StatementRowsDataResponse(
    int AllRowsCount,
    int Offset,
    decimal StartBalance,
    decimal EndBalance,
    List<StatementRowResponse> Rows);
