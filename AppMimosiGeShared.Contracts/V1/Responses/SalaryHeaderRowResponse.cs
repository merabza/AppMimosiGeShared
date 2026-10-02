using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     უწყისების სიის ერთი სტრიქონი: თარიღები, სტრიქონების რაოდენობა და გადასარიცხი თანხების ჯამი
/// </summary>
public sealed record SalaryHeaderRowResponse(
    int ShId,
    DateTime ShChargeDate,
    DateTime ShTransferDate,
    int LinesCount,
    decimal AmountNetSum);
