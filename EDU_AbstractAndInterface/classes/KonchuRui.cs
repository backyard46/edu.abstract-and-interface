using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    /// <summary>
    /// LifeForm（生物）クラスを継承した昆虫類クラス。
    /// </summary>
    /// <seealso cref="EDU_InheritPractice.Lifeform" />
    class KonchuRui : Lifeform
    {
        // 昆虫類: ここでは特徴を「足が6本」とします。

        /// <summary>
        /// Initializes a new instance of the <see cref="HachuRui"/> class.
        /// </summary>
        public KonchuRui()
        {
            // 昆虫類用の基本設定を行う。
            this.RaceName1 = "昆虫類";
            this.RaceName2 = string.Empty;

            // 昆虫類の足は6本。
            this.LegsCount = 6;
        }

        // IsFlyingプロパティ用変数。
        private bool isFlying = false;

        /// <summary>
        /// 飛行中かどうかの状態を設定、参照するプロパティ。
        /// </summary>
        /// <remarks>
        /// 飛行中の場合True、飛行中でない場合はFalse。
        /// </remarks>
        public bool IsFlying
        {
            get { return isFlying; }
            set { isFlying = value; }
        }

        /// <summary>
        /// 飛ぶ。
        /// </summary>
        /// <returns>飛べた場合はTrue、飛べなかった場合はFalse。</returns>
        public bool Fly()
        {
            IsFlying = true;
            return true;
        }

        /// <summary>
        /// 着地する。
        /// </summary>
        /// <returns>着地出来た場合はTrue、着地出来なかった場合はFalse。</returns>
        public bool Land()
        {
            if (IsFlying)
            {
                IsFlying = false;
                return true;
            }
            else
            {
                return false;
            }
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
            if (IsFlying)
            {
                result += "飛んでいる" + "\r\n";
            }
            return result;
        }
    }
}
