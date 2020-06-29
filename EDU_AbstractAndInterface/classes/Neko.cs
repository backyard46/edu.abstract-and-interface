using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    class Neko: HonyuRui
    {
        /// <summary>
        /// 何も指定しないコンストラクター。個体名には「猫（哺乳類）」が設定されます。
        /// </summary>
        public Neko()
        {
            // RaceName1は「哺乳類クラス」で設定されているはずなのでここでは設定しません。
            this.RaceName2 = "猫";
            this.IndividualName = "猫（哺乳類）";
        }

        /// <summary>
        /// 個体名を指定するタイプのコンストラクター。
        /// </summary>
        /// <param name="name">猫の個体名。</param>
        public Neko(string name)
        {
            this.RaceName2 = "猫";
            this.IndividualName = name;
        }

        // IsRunningプロパティ用変数。
        private bool isRunning = false;

        /// <summary>
        /// 猫が走っているかどうかを確認するプロパティ。
        /// </summary>
        /// <remarks>
        /// 走っている場合はTrue、止まっている場合はFalse。
        /// </remarks>
        public bool IsRunning
        {
            get { return isRunning; }
        }

        /// <summary>
        /// 猫がジャンプします！
        /// </summary>
        /// <returns>ジャンプ成功したらTrue。というか失敗などしない。</returns>
        public bool Jump()
        {
            return true;
        }

        /// <summary>
        /// 猫が走ります。
        /// </summary>
        /// <returns>走れた場合はTrue。</returns>
        public bool Run()
        {
            // 走行状態をTrueに設定。
            isRunning = true;
            return true;
        }

        /// <summary>
        /// 走っている猫を止めます。
        /// </summary>
        /// <returns>止まれた場合はTrue、既に止まっている場合はFalse。</returns>
        public bool Stop()
        {
            if (isRunning)
            {
                // 既に走っている場合は停止。
                isRunning = false;
                return true;
            }
            else
            {
                // 既に止まっている場合はもう止まれないのでFalse。
                return false;
            }
        }

        /// <summary>
        /// 猫が噛みます。噛んで与えたダメージ値を返します。
        /// </summary>
        /// <returns>噛んで与えたダメージ値。</returns>
        public int Bite()
        {
            return 15;
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
            if (IsRunning)
            {
                result += "走っている" + "\r\n";
            }

            return result;
        }
    }
}
