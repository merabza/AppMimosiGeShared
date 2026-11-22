using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბრძანებების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset და სტრიქონები
/// </summary>
public sealed record GroupOrdersRowsDataResponse(int AllRowsCount, int Offset, List<GroupOrderRowResponse> Rows);
