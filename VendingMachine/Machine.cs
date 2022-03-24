class Machine
{
    public List<Slot> Slots { get; set; } = new List<Slot>();

    public Machine()
    {
        Slots.Add(new Slot(1, "Marabou Mjölkchoklad", 25));
        Slots.Add(new Slot(2, "Marabou Pepparkaka", 15));
        Slots.Add(new Slot(3, "Marabou Popcorn", 20));
        Slots.Add(new Slot(4, "Marabou Havsalt", 25));
        Slots.Add(new Slot(5, "Marabou Japp", 25));
        Slots.Add(new Slot(6, "Marabou Daim", 20));
        Slots.Add(new Slot(7, "Marabou Helnöt", 15));
        Slots.Add(new Slot(8, "Marabou Oreo", 25));
    }

}
