using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RefineData;

public class RefinePlace : MonoBehaviour {

    public ItemAssetMenu items;

    private void Start()
    {
        print(ReadRefineData.ReadLine(0));
    }

}
