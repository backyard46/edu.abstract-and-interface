using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    /// <summary>
    /// LifeForm（生物）クラスを継承した軟体動物クラス。
    /// </summary>
    /// <seealso cref="EDU_InheritPractice.Lifeform" />
    class NantaiRui : Lifeform
    {
        // 軟体動物: ここでは特徴を「足が0本」とします。

        /// <summary>
        /// Initializes a new instance of the <see cref="NantaiRui"/> class.
        /// </summary>
        public NantaiRui()
        {
            // 軟体動物の基本設定を行う。
            this.RaceName1 = "軟体動物";
            this.RaceName2 = string.Empty;

            // 軟体動物の足は0本。
            this.LegsCount = 0;
        }
        
        /// <summary>
        /// 現在のオブジェクトの状態を文字列で返します。
        /// </summary>
        /// <returns>
        /// 現在のオブジェクト状態を表す文字列。
        /// </returns>
        public override string ToString()
        {
            string result = base.ToString();
            return result;
        }
    }
}
