using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Infomation : MonoBehaviour {

    /// <summary>
    /// 接收到的物品清單
    /// </summary>
    public List<ItemAssetMenu> ItemsInfo = new List<ItemAssetMenu>();

    public List<GameObject> lstObj = new List<GameObject>();
    public GameObject ItemPrefab;
    public Transform Parent;


    private void Awake()
    {
        SetItems(ItemsInfo);
    }

    /// <summary>
    /// 建立物品
    /// </summary>
    public void SetItems (List<ItemAssetMenu> items)
    {
        foreach (ItemAssetMenu i in items)
        {
            GameObject obj = Instantiate(ItemPrefab, Parent);
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
        foreach (ItemAssetMenu ItemAsset in ItemsInfo)
        {

            if(ItemAsset.items.Name != lstObj[i].name)
            {
                return false;
            }
            i++;
        }
        return true;
    }
}
