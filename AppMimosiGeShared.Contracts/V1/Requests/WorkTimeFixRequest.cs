namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     "სამუშაოს დაწყების" ან "დასრულების" დაფიქსირება სერვერის ახლანდელი დროით. TeacherContractId თანამშრომლის
///     კონტრაქტია (null: არ აურჩევიათ). LuftMinutes "ლუფტია" წუთებში: დაწყება ამდენით ადრე, დასრულება ამდენით გვიან
///     ფიქსირდება; null და უარყოფითი 0-ს ნიშნავს, 30-ზე მეტი შეცდომაა (Access-ის FrmWorkHours)
/// </summary>
public sealed class WorkTimeFixRequest
{
    public int? TeacherContractId { get; init; }
    public int? LuftMinutes { get; init; }
}
