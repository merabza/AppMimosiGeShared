namespace AppMimosiGeShared.Contracts.V1.Responses;

public sealed record StudentContractDetailResponse(
    int Id,
    int CourseId,
    int GroupSizeId,
    float FourWeekHours,
    decimal FourWeekFee,
    decimal OneHourFee);
