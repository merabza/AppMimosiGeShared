using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ნამუშევარი დროის სიისა და ფორმის ცნობარი: თანამშრომლები, ანუ სამუშაო საათების ჯგუფის მქონე კონტრაქტები
///     "გვარი სახელი / ნომერი"-თ, ამ სახელით დალაგებული (Access-ის FrmWorkHours-ის ჩამოსაშლელი სია)
/// </summary>
public sealed record WorkHourFormLookupsResponse(List<LookupItemResponse> Employees);
