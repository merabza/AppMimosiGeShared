using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გადახდების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, მათი თანხების ჯამი (ყველა გვერდისა,
///     Access-ის ფორმის footer-ის "ჯამი"), რეალური offset და სტრიქონები
/// </summary>
public sealed record PaymentsRowsDataResponse(
    int AllRowsCount,
    int Offset,
    decimal TotalAmount,
    List<PaymentRowResponse> Rows);
