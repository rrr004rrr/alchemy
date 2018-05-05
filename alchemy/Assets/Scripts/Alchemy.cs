using System.Collections.Generic;
using UnityEngine;

public class Alchemy : MonoBehaviour {

    #region 變數

    private AlchemySystem fAlchemySystem;

    #endregion

    // Use this for initialization
    void Start () {
        fAlchemySystem = AlchemySystem.GetInstance();
    }
	
	// Update is called once per frame
	void Update () {
        //取得素材清單 顯示
        fAlchemySystem.GetMaterials();
	}

    private void OnMouseDown()
    {
        //點擊素材 加入
        fAlchemySystem.AddMaterial(string.Empty);

        //點擊素材 移除
        fAlchemySystem.RemoveMaterial(string.Empty);
    }

    private void OnMouseUpAsButton()
    {
        //點擊合成按鈕
        string result = fAlchemySystem.Refine();
    }

    /// <summary>
    /// 合成系統
    /// </summary>
    private class AlchemySystem
    {
        /// <summary>
        /// 素材集合
        /// </summary>
        private List<string> fMaterial;

        /// <summary>
        ///  唯一實體
        /// </summary>
        private static AlchemySystem fInstance;

        /// <summary>
        /// 目前煉成的配方
        /// </summary>
        private Receipt fReceipt;

        private AlchemySystem()
        {
            fMaterial = new List<string>();
        }

        /// <summary>
        /// 取得實體
        /// </summary>
        /// <returns></returns>
        public static AlchemySystem GetInstance()
        {
            if(fInstance == null)
            {
                fInstance = new AlchemySystem();
            }
            return fInstance;
        }

        /// <summary>
        /// 取得素材
        /// </summary>
        /// <returns></returns>
        public List<string> GetMaterials()
        {
            return fMaterial;
        }

        #region 加入素材

        /// <summary>
        /// 加入素材
        /// </summary>
        /// <param name="singleMaterial"></param>
        /// <param name="insertIndex"></param>
        public void AddMaterial(string singleMaterial, int insertIndex = 0)
        {
            if (insertIndex != 0)
            {
                fMaterial.Add(singleMaterial);
            }
            else
            {
                fMaterial.Insert(insertIndex, singleMaterial);
            }

        }

        #endregion

        #region 移除素材

        /// <summary>
        /// 移除素材
        /// </summary>
        /// <param name="removeindex"></param>
        public void RemoveMaterial(int removeindex)
        {
            fMaterial.RemoveAt(removeindex);
        }

        /// <summary>
        /// 移除素材
        /// </summary>
        /// <param name="singleMaterial"></param>
        public void RemoveMaterial(string singleMaterial)
        {
            fMaterial.Remove(singleMaterial);
        }

        #endregion

        #region 取得配方

        private Receipt getReceipt()
        {
            return new Receipt();
        }

        #endregion

        #region 煉成

        /// <summary>
        /// 煉成(會消耗全部的素材)
        /// </summary>
        /// <returns></returns>
        public string Refine()
        {
            string result;

            fReceipt = getReceipt();

            int maxNumber = fReceipt.GetProbabilityMaxNumber();
            int randomNumber = getRandomNumber(maxNumber);

            int resultIndex = getReceiptResultIndex(randomNumber);

            result = fReceipt.Result[resultIndex];

            //清空素材
            fMaterial.Clear();

            return result;
        }

        /// <summary>
        /// 取得一個介於0 ~ maxNumber的隨機數
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        private int getRandomNumber(int maxNumber)
        {
            return Random.Range(0 , maxNumber);
        }

        /// <summary>
        /// 尋找配方結果位置
        /// </summary>
        /// <param name="randomNumber"></param>
        /// <returns></returns>
        private int getReceiptResultIndex(int randomNumber)
        {
            int resultIndex = 0;

            for (; resultIndex < fReceipt.Result.Count; resultIndex += 1)
            {
                if (randomNumber > fReceipt.Probability[resultIndex])
                {
                    break;
                }
            }

            return resultIndex
        }

        #endregion
    }

    /// <summary>
    /// 配方
    /// </summary>
    private class Receipt
    {
        /// <summary>
        /// 機率(目前想以 [10,25,75,100]這種方式 然後取得隨機數 再與這邊比較 取得索引 再去結果裡拿資料)
        /// </summary>
        public List<int> Probability{ get; set; }

        public List<string> Result { get; set; }

        public Receipt()
        {
            Probability = new List<int>();
            Result = new List<string>();
        }

        public int GetProbabilityMaxNumber()
        {
            return Probability.IndexOf(Probability.Count-1);
        }
    }


}
