using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბალანსების სია და Access-ის ფორმის footer-ის ჯამები (ნაჩვენები სტრიქონების ბალანსები და ოთხკვირიანი გადასახადები)
/// </summary>
public sealed record DepositsResponse(decimal TotalBalance, decimal TotalFourWeekFee, List<DepositRowResponse> Rows);
