using System.Text;

class ShoppingCart
{
    public List<GroupedShopItem> Groceries = new List<GroupedShopItem>();

    public void AddItem(ShopItem item)
    {
        GroupedShopItem? res = FindItem(item);

        if (res != null)
        {
            res.Quantity++;
            return;
        }
        
        Groceries.Add(new GroupedShopItem(item));
    }

    public void AddItem(ShopItem item, int amount) => Enumerable.Range(0, amount).ToList().ForEach(_ => AddItem(item));

    public GroupedShopItem? FindItem(ShopItem item)
    {
        foreach (GroupedShopItem groupedItem in Groceries)
        {
            if (groupedItem.Item.ID == item.ID)
                return groupedItem;
        }

        return null;
    }

    public string Contents()
    {
        StringBuilder res = new StringBuilder();

        foreach (GroupedShopItem groupedItem in Groceries)
        {
            res.Append($"{groupedItem.Item.Name} x {groupedItem.Quantity}\n");
        }

        return res.ToString();
    }

    public double TotalPrice() => Groceries.Select(x => x.Quantity * x.Item.Price).Sum();
}