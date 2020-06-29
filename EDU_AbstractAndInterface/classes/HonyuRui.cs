using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    /// <summary>
    /// LifeForm（生物）クラスを継承した哺乳類クラス。
    /// </summary>
    /// <seealso cref="EDU_InheritPractice.Lifeform" />
    class HonyuRui : Lifeform
    {
        // 哺乳類: ここでは特徴を「足が4本の生き物」とします。

        /// <summary>
        /// Initializes a new instance of the <see cref="HonyuRui"/> class.
        /// </summary>
        public HonyuRui()
        {
            // 哺乳類用の基本設定を行う。
            this.RaceName1 = "哺乳類";
            this.RaceName2 = string.Empty;

            // 哺乳類の足は4本。
            this.LegsCount = 4;
        }
    }
}
