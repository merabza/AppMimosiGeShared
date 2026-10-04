using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტების კატალოგი მიმდინარე მომხმარებლისთვის (Access-ის FrmMain: კატეგორიები და მათი რეპორტები): მხოლოდ ის
///     რეპორტები, რომლებზეც მას უფლება აქვს, და მხოლოდ ის კატეგორიები, რომლებშიც ასეთი რეპორტი არის
/// </summary>
public sealed record ReportCatalogResponse(List<ReportCategoryResponse> Categories, List<ReportInfoResponse> Reports);
