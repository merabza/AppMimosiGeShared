using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     პროგრამის რეჟიმი (D183). IsOrdersMode: ჯგუფი მხოლოდ ბრძანებით იცვლება და ჯგუფის ფორმა მხოლოდ სანახავია.
///     TransitionDate: ბრძანებებზე გადასვლის დღე (D0). SwitchedByUserName და SwitchedAt: ვინ და როდის გადართო რეჟიმი
///     ბოლოს (ცარიელია, თუ არასოდეს გადართულა)
/// </summary>
public sealed record GroupOrdersModeResponse(
    bool IsOrdersMode,
    DateTime? TransitionDate,
    string? SwitchedByUserName,
    DateTime? SwitchedAt);
