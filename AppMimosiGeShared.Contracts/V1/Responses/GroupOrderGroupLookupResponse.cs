using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჯგუფი ბრძანების ფორმისა და სიის ფილტრის ჩამოსაშლელ სიაში. CanHaveOrders: ჯგუფს აქვს საწყისი ბრძანება ან
///     გააქტიურებული შექმნის ბრძანება, ამიტომ მას ახალი ბრძანება შეიძლება (D202); გადაყვანის სამიზნესაც ეს სჭირდება
/// </summary>
public sealed record GroupOrderGroupLookupResponse(
    int GrpId,
    string GroupCode,
    int AcademicYearId,
    int CourseId,
    int GroupSizeId,
    DateTime? VoidDate,
    bool CanHaveOrders);
