using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ნამუშევარი დროის სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset, სტრიქონები და
///     თანამშრომლების ჯამური საათები ფილტრის ყველა ჩანაწერზე (სახელით დალაგებული)
/// </summary>
public sealed record WorkHoursRowsDataResponse(
    int AllRowsCount,
    int Offset,
    List<WorkHourRowResponse> Rows,
    List<WorkHoursTotalResponse> Totals);
