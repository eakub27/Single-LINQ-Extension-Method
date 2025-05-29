// See https://aka.ms/new-console-template for more information

internal class Purchase
{
    public int InvNo { get; set; }
    public int ItemId { get; set; }
    public int PurQty { get; set; }
    // Constructor to initialize Purchase objects

    public Purchase() { }
    public Purchase(int invNo, int itemId, int purQty)
    {
        InvNo = invNo;
        ItemId = itemId;
        PurQty = purQty;
    }
}