using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     სასწავლო წელი ოსტატისთვის: კონტრაქტების და ჯგუფების რაოდენობა, მათ შორის დაუხურავი ჯგუფები (VoidDate ცარიელია
///     ან წლის დასრულების შემდეგაა)
/// </summary>
public sealed record AcademicYearInfoResponse(
    int AyId,
    string AcademicYearName,
    DateTime StartDate,
    DateTime FinishDate,
    int StudentContractsCount,
    int GroupsCount,
    int OpenGroupsCount);
