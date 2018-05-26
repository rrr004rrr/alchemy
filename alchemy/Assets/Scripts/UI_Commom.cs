using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Commom : MonoBehaviour {

    [Header("打開自動產生畫面，測試畫面請勿打勾。")]
    public bool isCreateCanvas = false;

    [Header("重新產生畫面")]
    public bool isRemakeCanvas = false;

    [Header("0 = Information , 1 = Map , 2 = Alchemy , 3 = Shop")]
    public List<GameObject> canvasPrefabs = new List<GameObject>();
    private List<Canvas> allCanvas = new List<Canvas>();

    private void Awake()
    {
        //自動產生畫面
        if (isCreateCanvas)
        {
            CreateCanvas();
        }
        Open(0);
    }

    private void Update()
    {
        if (isRemakeCanvas)
        {
            DeleteCanvas();
            CreateCanvas();
            Open(0);
            isRemakeCanvas = false;
        }
    }

    /// <summary>
    /// 生成畫面
    /// </summary>
    void CreateCanvas()
    {
        foreach (GameObject c in canvasPrefabs)
        {
            Canvas canvas = Instantiate(c).GetComponent<Canvas>();
            canvas.gameObject.name = c.name;
            allCanvas.Add(canvas);
        }
    }

    /// <summary>
    /// 清除畫面
    /// </summary>
    void DeleteCanvas()
    {
        foreach (Canvas canvas in allCanvas)
        {
            if(canvas != null)
            {
                Destroy(canvas.gameObject);
            }
        }
        allCanvas.Clear();
    }

    /// <summary>
    /// 初始化所有畫面,只顯示第一頁
    /// </summary>
    void Init ()
    {        
        Open(0);
    }

    /// <summary>
    /// 開啟某頁面
    /// </summary>
    /// <param name="number">畫面編號</param>
    public void Open (int number)
    {
        int num = 0;
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
                Debug.LogError("UI_Common/Open (開關頁面) ==> canvas ["+ num + "] 是空的");
            }
            num++;
        }
    }
}
