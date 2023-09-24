namespace WF_H_004_DBMS.Models
{
    /// <summary>
    /// Having選項模型
    /// </summary>
    public class HavingOption
    {
        /// <summary>
        /// 功能
        /// </summary>
        public string ColFunc { get; set; }

        /// <summary>
        /// 欄位名稱
        /// </summary>
        public string ColName { get; set; }

        /// <summary>
        /// 條件
        /// </summary>
        public string ColCond { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string ColValue { get; set; }
    }
}
