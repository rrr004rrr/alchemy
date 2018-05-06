using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RefineCanvas : MonoBehaviour
{
    //背包物件
    public List<ItemAssetMenu> BackpackItem ;



    /// <summary>
    /// 初始化背包物件
    /// </summary>
    void InitBackpackItems ()
    {
        //將背包還原初始狀態
        InitBackpack();

        //獲取背包數據
        //BackpackItem =

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

    }

    /// <summary>
    /// 生成背包物件
    /// </summary>
    void CreateBackpackItems ()
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

        return true;
    }
}