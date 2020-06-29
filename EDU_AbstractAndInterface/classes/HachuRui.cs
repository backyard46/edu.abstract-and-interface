using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    /// <summary>
    /// LifeForm（生物）クラスを継承した爬虫類クラス。
    /// </summary>
    /// <seealso cref="EDU_InheritPractice.Lifeform" />
    class HachuRui : Lifeform
    {
        // 爬虫類: ここでは特徴を「足が4本」「脱皮する」とします。

        /// <summary>
        /// Initializes a new instance of the <see cref="HachuRui"/> class.
        /// </summary>
        public HachuRui()
        {
            // 爬虫類用の基本設定を行う。
            this.RaceName1 = "爬虫類";
            this.RaceName2 = string.Empty;

            // 爬虫類の足は4本。
            this.LegsCount = 4;
        }

        /// <summary>
        /// 脱皮。
        /// </summary>
        /// <returns>脱皮できた場合はTrue、できなかった場合はFalse。</returns>
        public bool Moult()
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
