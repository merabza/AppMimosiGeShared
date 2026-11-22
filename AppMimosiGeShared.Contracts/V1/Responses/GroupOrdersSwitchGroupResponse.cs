using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჯგუფი ვიზარდი 1-ის რეპორტში. InitialOrderDate: საწყისი ბრძანების თარიღი, ჯგუფის პირველი მოქმედი დღე, წარსულში
///     ან მომავალში (D196). ცარიელია, თუ ჯგუფი არასოდეს გახდება მოქმედი: ასეთი ჯგუფი საწყის ბრძანებას ვერ მიიღებს და
///     ბრძანებით ვეღარ შეიცვლება (D202)
/// </summary>
public sealed record GroupOrdersSwitchGroupResponse(int GrpId, string GroupCode, DateTime? InitialOrderDate);
