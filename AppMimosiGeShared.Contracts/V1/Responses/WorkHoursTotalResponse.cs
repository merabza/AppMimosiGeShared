namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი თანამშრომლის ჯამი სიის ფილტრის ყველა ჩანაწერზე (ყველა გვერდისა): Hours დასრულებული ჩანაწერების
///     ხანგრძლივობების ჯამია საათებში (2 ათწილადით), RecordsCount ყველა ჩანაწერის რაოდენობა, დაუსრულებლის ჩათვლით
/// </summary>
public sealed record WorkHoursTotalResponse(
    int TeacherContractId,
    string EmployeeName,
    decimal Hours,
    int RecordsCount);
