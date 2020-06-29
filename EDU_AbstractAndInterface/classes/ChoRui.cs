using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    /// <summary>
    /// LifeForm（生物）クラスを継承した鳥類クラス。
    /// </summary>
    /// <seealso cref="EDU_InheritPractice.Lifeform" />
    class ChoRui : Lifeform, IEggCreatable
    {
        // 鳥類: ここでは特徴を「足が2本」「翼を2つ持つ」「飛べるものも居る」とします。

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoRui"/> class.
        /// </summary>
        public ChoRui()
        {
            // 鳥用の基本設定を行う。
            this.RaceName1 = "鳥類";
            this.RaceName2 = string.Empty;

            // 鳥類の足は2本。
            this.LegsCount = 2;
        }

        // WingsCount用変数。
        private int wingsCount = 0;

        /// <summary>
        /// 翼の数を設定、参照するプロパティ。
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">WingsCount - 翼の数は0以上で指定する必要があります。</exception>
        public int WingsCount
        {
            get { return wingsCount; }
            set
            {
                if (value>=0)
                {
                    wingsCount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("WingsCount", "翼の数は0以上で指定する必要があります。");
                }
            }
        }

        // CanFlyプロパティ用変数。
        private bool canFly = true;

        /// <summary>
        /// 飛べるかどうかを指定、参照するプロパティ。
        /// </summary>
        public bool CanFly
        {
            get { return canFly; }
            set { canFly = value; }
        }

        private bool isFlying = false;

        /// <summary>
        /// 現在飛んでいるかどうかを取得するプロパティ。
        /// </summary>
        /// <remarks>
        /// 飛んでいる場合はTrue。飛んでいなければFalse。
        /// </remarks>
        public bool IsFlying
        {
            get { return isFlying; }
        }

        /// <summary>
        /// 飛ぶ。
        /// </summary>
        /// <returns>飛べた場合はTrue、飛べなかった場合はFalse。</returns>
        public bool Fly()
        {
            // CanFlyプロパティがTrueなら飛ぶ（戻り値=True）それ以外は飛べない（戻り値=False）。
            if (this.CanFly)
            {
                // 飛べる鳥の場合は飛行状態を「飛行中」に設定。Trueを返す。
                isFlying = true;
                return true;
            }
            else
            {
                // 飛べない鳥の場合はFalseを返す。
                return false;
            }
        }

        /// <summary>
        /// 着地。
        /// </summary>
        /// <returns>着地成功の場合はTrue、そもそも飛んでいなければFalse。</returns>
        public bool Land()
        {
            if (isFlying)
            {
                // 飛行中の場合は飛行状態を「着地中」に設定。Trueを返す。
                isFlying = false;
                return true;
            }
            else
            {
                // 飛んでいない場合はFalseを返す。
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
            result += "Wings:" + this.wingsCount.ToString() + "\r\n";
            if (this.CanFly)
            {
                result += "飛べる" + "\r\n";
            }
            if (this.IsFlying)
            {
                result += "飛んでいる" + "\r\n";
            }

            return result;
        }

        public bool CreateEgg()
        {
            // 卵生成処理
            return true;
        }
    }
}
