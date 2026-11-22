using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ვიზარდი 1-ის რეპორტის დარღვევა (D194): ჯგუფი, დარღვეული წესი (შეცდომის კოდი და ტექსტი, როგორც ჯგუფის შენახვისას),
///     დღე, როცა წესი ირღვევა, და სტრიქონის აღწერა. Date და Row ცარიელია, როცა დარღვევა მთელ ჯგუფს ეხება
/// </summary>
public sealed record GroupOrdersSwitchViolationResponse(
    int GrpId,
    string GroupCode,
    string ErrorCode,
    string ErrorText,
    DateTime? Date,
    string? Row);
