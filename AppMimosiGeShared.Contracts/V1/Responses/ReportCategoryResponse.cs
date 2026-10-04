using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტების კატეგორია. ReportKeys კატალოგის რიგითაა
/// </summary>
public sealed record ReportCategoryResponse(string Key, string Name, List<string> ReportKeys);
