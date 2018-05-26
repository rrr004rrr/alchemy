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

    public List<ShopAssetMenu> ShopAssetMenus;

    public  GameObject ShopItemPrefabs;

    public Transform Content;

    public GameObject ScrollView;

    public int Count = 20;

    /// <summary>
    /// 商店販賣物
    /// </summary>
    private List<GameObject> shopItems;

	// Use this for initialization
	public void Start () {
        initShopItems("City_A");
    }
	
	// Update is called once per frame
	public void Update () {
		
	}

    private void initShopItems(string cityName)
    {
        shopItems = new List<GameObject>();

        foreach (ShopAssetMenu m in ShopAssetMenus)
        {
            if(m.name == cityName)
            {
                foreach(ItemAssetMenu i in m.item)
                {
                    GameObject shopItem = Instantiate(ShopItemPrefabs, Content);
                    shopItem.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = i.item.Name;
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
