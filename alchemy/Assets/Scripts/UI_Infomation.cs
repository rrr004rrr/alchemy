using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variable;
using UnityEngine.UI;

public class ItemList
{
    public Items Item;
    public int Count;
}

public class UI_Infomation : MonoBehaviour {

    /// <summary>
    /// 接收到的物品清單
    /// </summary>
    public List<ItemList> ItemsLists = new List<ItemList>();

    public List<GameObject> lstObj = new List<GameObject>();
    public GameObject ItemPrefab;
    public Transform Parent;

    private void Awake()
    {
        SetItems();
    }

    /// <summary>
    /// 建立物品
    /// </summary>
    public void SetItems ()
    {
        for (int i = 0; i < 50; i++)
        {
            ItemsLists.Add(new ItemList());
        }

        print(ItemsLists.Count);

        for (int o = 0; o < ItemsLists.Count; o++)
        {
            GameObject obj = Instantiate(ItemPrefab, Parent);
            //if(ItemsLists[o].Item.Icon != null)
            //{
            //    //obj.transform.GetChild(1).GetComponent<Image>().sprite = ItemsLists[o].Item.Icon;
            
            //}
            lstObj.Add(obj);
        }

    }

    public void DeleteItems()
    {
        //GameObject.Destroy(Parent.Ch)
    }

    /// <summary>
    /// 判斷物品資訊是否有更新
    /// </summary>
    /// <returns>true代表有 , false代表沒有</returns>
    public bool IsUpdateItems ()
    {
        int i = 0;
        //foreach (Items c in ItemsList)
        //{

        //    //if(ItemAsset.items.Name != lstObj[i].name)
        //    //{
        //    //    return false;
        //    //}
        //    i++;
        //}
        return true;
    }
}
