using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RefineData
{
    public class ReadRefineData
    {
        public static TextAsset textAsset;
        public static string[] objInfoArray;

        public static void LoadRes()
        {
            textAsset = (TextAsset)Resources.Load("RefineData");
            objInfoArray = textAsset.text.Split('\n');
        }

        /// <summary>
        /// 取得某行數值
        /// </summary>
        /// <param name="line">行數</param>
        /// <returns></returns>
        public static string ReadLine (int line)
        {
            LoadRes();
            return objInfoArray[line];
        }

        /// <summary>
        /// 取得數量
        /// </summary>
        /// <returns></returns>
        public static int GetCount()
        {
            LoadRes();
            return objInfoArray.Length;
        }
    }
}

