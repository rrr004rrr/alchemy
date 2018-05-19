using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemAdapter : MonoBehaviour {

    public  RectTransform ShopItemPrefabs;

    public RectTransform Content;

    public GameObject ScrollView;

    /// <summary>
    /// 商店販賣物
    /// </summary>
    private List<ItemAssetMenu.Item> shopItems;

	// Use this for initialization
	public void Start () {

	}
	
	// Update is called once per frame
	public void Update () {
		
	}

    private void initShopItems()
    {
        shopItems = new List<ItemAssetMenu.Item>();

        foreach(ItemAssetMenu.Item item in shopItems)
        {
            GameObject shopItem = Instantiate(ShopItemPrefabs.gameObject);
            shopItem.transform.SetParent(Content, false);
            //ScrollView.transform;
        }
    }

    public class ShopItemView
    {



        public ShopItemView(Transform rootView)
        {
            
        }
    }
}
