using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variable;

public class UI_Manager : MonoBehaviour {

    public UI_Commom ui_commom;

    public List<ItemAssetMenu> xx = new List<ItemAssetMenu>();

    public Items item;

    // Use this for initialization
    void Start () {
        print(xx[2].item.Name);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
