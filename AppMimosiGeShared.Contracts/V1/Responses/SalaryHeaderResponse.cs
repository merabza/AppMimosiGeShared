using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     უწყისი მდგენელებით, სტრიქონებით და სტრიქონების დეტალებით (ჯგუფების მიხედვით)
/// </summary>
public sealed record SalaryHeaderResponse(
    int ShId,
    DateTime ShChargeDate,
    DateTime ShTransferDate,
    List<SalaryPartResponse> Parts,
    List<SalaryLineResponse> Lines,
    List<SalaryLineDetailResponse> Details);
