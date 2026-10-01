using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     CRM ზარების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset და სტრიქონები
/// </summary>
public sealed record CrmCallsRowsDataResponse(int AllRowsCount, int Offset, List<CrmCallRowResponse> Rows);
