using System.Collections;
using System.Collections.Generic;
using Enum;

namespace Variable
{
    /// <summary>
    /// 配方
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// 合成結果
        /// </summary>
        public Items ResultItem { get; set; }

        /// <summary>
        /// 副素材屬性
        /// </summary>
        public List<Arrtibutes> OtherAttributes{ get; set; }

        /// <summary>
        /// 合成用權重
        /// </summary>
        public int RefineWeight{ get; set; }

    }

}
