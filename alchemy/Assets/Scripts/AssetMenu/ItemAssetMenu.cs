using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ItemAssetMenu : ScriptableObject
{


    [System.Serializable]
    public class Item
    {
        public enum EPYT
        {
            A,
            B,
            C,
            D
        }

        public int Number;
        public string Name;
        public EPYT XXX = new EPYT();
        public int Infomation;    
        public string Price;
    }



    public List<Item> items;
}

