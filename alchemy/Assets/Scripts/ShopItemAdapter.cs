using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemAdapter : MonoBehaviour {

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
        initShopItems();
    }
	
	// Update is called once per frame
	public void Update () {
		
	}

    private void initShopItems()
    {
        shopItems = new List<GameObject>();

        for(int i =0; i < Count; i++)
        {
            GameObject shopItem = Instantiate(ShopItemPrefabs,Content);
            shopItems.Add(shopItem);
        }
    }

    public class ShopItemView
    {



        public ShopItemView(Transform rootView)
        {
            
        }
    }
}
