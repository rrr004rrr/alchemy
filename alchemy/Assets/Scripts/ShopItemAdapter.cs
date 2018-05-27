using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop
{
    public string city;
    public int itemsMenu;
}

public class ShopItemAdapter : MonoBehaviour {

    [Header("商品預置物")]
    public GameObject ShopItemPrefabs;

    [Header("各商店的AssetMenu")]
    public List<ShopAssetMenu> ShopAssetMenus;

    /// <summary>
    /// 商店販賣物
    /// </summary>
    private List<GameObject> shopItems;

    public Transform Content;

    private string itemName;
    private Enum.Arrtibutes arrtibute;
    private int itemLevel;
    private Sprite icon;
    private string description;
    private int price;

    // Use this for initialization
    public void Start () {
        initShopItems("City_A");
    }
	
	// Update is called once per frame
	public void Update () {
		
	}

    public void initShopItems(string cityName)
    {
        shopItems = new List<GameObject>();

        foreach (ShopAssetMenu m in ShopAssetMenus)
        {
            if(m.name == cityName)
            {
                foreach(ItemAssetMenu i in m.item)
                {
                    #region 取值
                    itemName = i.item.Name;
                    arrtibute = i.item.Arrtibute;
                    itemLevel = i.item.ItemLevel;
                    icon = Resources.Load<Sprite>("Sprites/itemIcon/itemIcon_" + i.item.Icon);
                    description = i.item.Description;
                    price = i.Price;
                    #endregion

                    GameObject shopItem = Instantiate(ShopItemPrefabs, Content);

                    shopItem.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = icon;

                    shopItem.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = "物品名稱："+itemName;
                    shopItem.transform.GetChild(1).GetChild(1).GetChild(1).GetComponent<Text>().text = "物品等級：" + itemLevel.ToString();
                    shopItem.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<Text>().text = description;

                    shopItem.transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "總價：" + price.ToString();

                    shopItems.Add(shopItem);
                }            
            }
        }
        
    }

    public class ShopItemView
    {



        public ShopItemView(Transform rootView)
        {
            
        }
    }
}
