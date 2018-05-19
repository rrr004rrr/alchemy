using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ItemAssetMenu : ScriptableObject
{
    [Serializable]
    public class Item
    {
        //名字
        public String Name;

        /// <summary>
        /// 屬性
        /// 0.無
        /// 1.
        /// 2.
        /// 3.
        /// 4.
        /// 5.
        /// </summary>
        public int Attributes;

        /// <summary>
        /// 物品等級  (介於1~10)
        /// </summary>
        public int ItemLevel;

        //圖片
        public Sprite Icon;

        //敘述
        public String Description;
    }

    public Item items;
    

}

