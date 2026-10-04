using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტების ფილტრების ჩამოსაშლელი სიები (Access-ის FrmMain-ის cmbTeacherID, cmbCourceID, cmbStudentID):
///     მასწავლებლები და მოსწავლეები "გვარი სახელი / ნომერი"-თ, საგნები სახელით; ყველა სახელით ლაგდება
/// </summary>
public sealed record ReportLookupsResponse(
    List<LookupItemResponse> Teachers,
    List<LookupItemResponse> Courses,
    List<LookupItemResponse> Students);
