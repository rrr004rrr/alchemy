using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Backpack : MonoBehaviour
{
    //-----畫面部分-----//
    //背包預置物
    public GameObject BackpackItems;
    public List<GameObject> RefinePlace;


    //背包物件
    public List<ItemAssetMenu> BackpackItem = new List<ItemAssetMenu>();

    public List<ItemAssetMenu> updateBackpackItem;

    //檢查背包次數，最多3次
    private int checkBackpackTimes = 0;


    void Awake()
    {
        InitBackpackItems();
    }

    void onClick_AddToRefine ()
    {
        List<ItemAssetMenu> items = new List<ItemAssetMenu>();
        for (int i = 0; i < RefinePlace.Count; i++)
        {
            if (RefinePlace[i].GetComponent<RefinePlace>().items == null)
                RefinePlace[i].GetComponent<RefinePlace>().items = new ItemAssetMenu();
            items.Add(RefinePlace[i].GetComponent<RefinePlace>().items);
        }
    }


    /// <summary>
    /// 初始化背包物件
    /// </summary>
    void InitBackpackItems ()
    {
        //將背包還原初始狀態
        InitBackpack();

        ////獲取背包數據
        //ItemAssetMenu itemAssetMenu1 = new ItemAssetMenu { name = "我是1號" };
        //BackpackItem.Add(itemAssetMenu1);
        //updateBackpackItem.Add(itemAssetMenu1);

        //ItemAssetMenu itemAssetMenu2 = new ItemAssetMenu { name = "我是2號" };
        //BackpackItem.Add(itemAssetMenu2);
        //updateBackpackItem.Add(itemAssetMenu2);

        //ItemAssetMenu itemAssetMenu3 = new ItemAssetMenu { name = "我是3號" };
        //BackpackItem.Add(itemAssetMenu3);
        //updateBackpackItem.Add(itemAssetMenu3);

        //如果背包有東西，則生成；沒有則中止。
        if (BackpackItem.Count > 0)
            CreateBackpackItems();
        else
            return;
        
        //檢查背包是否生成成功
        if (CheckBackpackItemsChange())
            InitBackpackItems();
    }

    /// <summary>
    /// 初始化背包
    /// </summary>
    void InitBackpack ()
    {
        RemoveBackpackItems();
    }

    /// <summary>
    /// 生成背包物件
    /// </summary>
    void CreateBackpackItems ()
    {

    }

    /// <summary>
    /// 清空背包物件
    /// </summary>
    void RemoveBackpackItems ()
    {

    }

    /// <summary>
    /// 刷新背包物件
    /// </summary>
    void ReflashBackpackItems ()
    {

    }

    /// <summary>
    /// 檢查背包是否有異
    /// </summary>
    bool CheckBackpackItemsChange ()
    {
        checkBackpackTimes++;
        //超過3次，當作沒有異常。
        if (checkBackpackTimes > 3)
        {
            checkBackpackTimes = 0;
            return false;
        }

        //重新取得一次背包資訊
        //updateBackpackItem = 背包資訊;

        bool isChange = false;

        if (updateBackpackItem == null)
            return true;

        for (int i = 0; i < updateBackpackItem.Count; i++)
        {
            isChange = !((updateBackpackItem[i].name == BackpackItem[i].name) ? true : false);
            if (isChange)
            {
                BackpackItem = updateBackpackItem;
                return isChange;
            }
        }
        return isChange;
    }
}