public class Item
{
    //Initializing name of item, and if item is being held.
    public string name;
    public bool holding_item;

    public Item(string name_val, bool holding_item_val)
    {
        name = name_val;
        holding_item = holding_item_val;
    }
    // Properties of HoldingItem
    // To create new item: Item itemName = new Item("name", false);
    // To change item to being held : itemName.HoldingItem = true;
    public bool HoldingItem
    {
        get { return holding_item; }
        set { holding_item = value; }
    }
}
