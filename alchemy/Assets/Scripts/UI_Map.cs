using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Map : MonoBehaviour {

    public List<string> cityName;

    public GameObject checkBox;

    private int gotoCity = 0;

	void Start () {
        checkBox.SetActive(false);
    }

    /// <summary>
    /// 開啟確認視窗
    /// </summary>
    /// <param name="cityNumber"></param>
    public void OpenCheckBox (int cityNumber)
    {
        gotoCity = cityNumber;
        checkBox.SetActive(true);
    }

    /// <summary>
    /// 確定移動到該城鎮
    /// </summary>
    public void Accept()
    {
        GoToCity(gotoCity);
        Cancel();
    }

    /// <summary>
    /// 取消移動到該城鎮
    /// </summary>
    public void Cancel()
    {
        checkBox.SetActive(false);
    }

    /// <summary>
    /// 移動到編號cityNumber的城鎮
    /// </summary>
    /// <param name="cityNumber"></param>
    private void GoToCity(int cityNumber)
    {
        Debug.Log("移動到" + cityName[cityNumber]);
    }
}
