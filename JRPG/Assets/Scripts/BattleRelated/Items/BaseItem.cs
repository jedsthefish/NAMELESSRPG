using UnityEngine;
using System.Collections;

public class BaseItem {

    private string itemName;
    private string itemDescription;
    private int itemID;
    public enum ItemTypes
    {
        equipment,
        weapon,
        scroll,
        potion,
        chest
    }
    private ItemTypes itemType;

    public string ItemName{ get; set; }
    public string ItemDescription { get; set; }
    public int ItemID { get; set; }
    public ItemTypes ItemType { get; set; }


}
