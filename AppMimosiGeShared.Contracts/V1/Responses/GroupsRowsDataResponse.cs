using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჯგუფების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset და სტრიქონები
/// </summary>
public sealed record GroupsRowsDataResponse(int AllRowsCount, int Offset, List<GroupRowResponse> Rows);
