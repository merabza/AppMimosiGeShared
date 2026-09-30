using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     თანამშრომლების კონტრაქტების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset და
///     სტრიქონები
/// </summary>
public sealed record TeacherContractsRowsDataResponse(
    int AllRowsCount,
    int Offset,
    List<TeacherContractRowResponse> Rows);
