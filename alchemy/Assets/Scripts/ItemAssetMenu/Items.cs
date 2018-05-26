using UnityEngine;
using Enum;

namespace Variable
{
    [System.Serializable]
    public class Items
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name = "123";

        /// <summary>
        /// 屬性
        /// </summary>
        public Arrtibutes Arrtibute = Arrtibutes.NULL;

        /// <summary>
        /// 物品等級  (介於1~10)
        /// </summary>
        public int ItemLevel = 7;

        /// <summary>
        /// 圖片
        /// </summary>
        public Sprite Icon = null;

        /// <summary>
        /// 敘述
        /// </summary>
        public string Description = "WHO?";
    }
}

