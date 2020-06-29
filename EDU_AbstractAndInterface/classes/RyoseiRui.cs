using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    /// <summary>
    /// LifeForm（生物）クラスを継承した両生類クラス。
    /// </summary>
    /// <seealso cref="EDU_InheritPractice.Lifeform" />
    class RyoseiRui : Lifeform
    {
        // 両生類: ここでは特徴を「足が4本」「泳げる」とします。

        /// <summary>
        /// Initializes a new instance of the <see cref="HachuRui"/> class.
        /// </summary>
        public RyoseiRui()
        {
            // 両生類用の基本設定を行う。
            this.RaceName1 = "両生類";
            this.RaceName2 = string.Empty;

            // 両生類の足は4本。
            this.LegsCount = 4;
        }

        /// <summary>
        /// 泳ぐ。
        /// </summary>
        /// <returns>泳げた場合はTrue、できなかった場合はFalse。</returns>
        public bool Swim()
        {
            // とりあえず成功するモノとしておく。
            return true;
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
