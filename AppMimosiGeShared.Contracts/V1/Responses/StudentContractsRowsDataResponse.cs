using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     კონტრაქტების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset და სტრიქონები
/// </summary>
public sealed record StudentContractsRowsDataResponse(
    int AllRowsCount,
    int Offset,
    List<StudentContractRowResponse> Rows);
