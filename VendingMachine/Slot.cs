class Slot
{
    public Product Product { get; }
    public int SlotNumber { get; }
    public Slot(int slotNumber, string productName, int productPrice)
    {
        SlotNumber = slotNumber;
        Product = new Product(productName, productPrice);
    }
}

