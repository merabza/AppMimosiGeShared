namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ვიზარდი 2-ის, „ჯგუფების რედაქტირებაზე დაბრუნების", შედეგი (D195). FileName: ფაილი ბრძანებებით, რომელიც ჩაიწერა
///     წაშლამდე (GroupOrders_yyyyMMddHHmmss.json); მას გადმოსაწერი endpoint აქვს (GroupOrdersModeRoute.ExportFile).
///     OrdersCount: წაშლილი ბრძანებების რაოდენობა, დაპაუზებულების ჩათვლით
/// </summary>
public sealed record SwitchToGroupEditingResponse(string FileName, int OrdersCount);
