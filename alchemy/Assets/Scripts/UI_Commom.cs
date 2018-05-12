using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Commom : MonoBehaviour {

    public List<Canvas> allCanvas = new List<Canvas>();

    private void Awake()
    {
        OpenCanvas(0);
    }

    /// <summary>
    /// 初始化所有畫面,只顯示第一頁
    /// </summary>
    void InitCanvas ()
    {
        OpenCanvas(0);
    }

    /// <summary>
    /// 開啟某頁面
    /// </summary>
    /// <param name="number">畫面編號</param>
    void OpenCanvas (int number)
    {
        if (allCanvas.Count == 0)
        {
            return;
        }

        foreach (Canvas canvas in allCanvas)
        {
            if (canvas != null)
            {
                canvas.enabled = (canvas == allCanvas[number]) ? true : false;
            }
            else
            {
                Debug.LogError("Mystery ==> canvas 是空的");
            }
        }
    }
}
