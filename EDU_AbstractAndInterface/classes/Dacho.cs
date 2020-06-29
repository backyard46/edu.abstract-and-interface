using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    class Dacho : ChoRui
    {
        /// <summary>
        /// 何も指定しないコンストラクター。個体名には「ダチョウ（鳥類）」が設定されます。
        /// </summary>
        public Dacho()
        {
            // RaceName1は「鳥類クラス」で設定されているはずなのでここでは設定しません。
            this.RaceName2 = "ダチョウ";
            this.IndividualName = "ダチョウ（鳥類）";
            this.WingsCount = 2;
        }

        /// <summary>
        /// 個体名を指定するタイプのコンストラクター。
        /// </summary>
        /// <param name="name">ダチョウの個体名。</param>
        public Dacho(string name)
        {
            this.RaceName2 = "ダチョウ";
            this.IndividualName = name;
            this.WingsCount = 2;
        }

        // IsRunningプロパティ用変数。
        private bool isRunning = false;

        /// <summary>
        /// 走っているかどうかを設定、参照するプロパティ。
        /// </summary>
        /// <remarks>
        /// 走っている場合はTrue、走っていない場合はFalse。
        /// </remarks>
        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; }
        }

        /// <summary>
        /// ダチョウが突きます。突き刺して与えたダメージ値を返します。
        /// </summary>
        /// <returns>突き刺して与えたダメージ値。</returns>
        public int Thrust()
        {
            return 25;
        }

        /// <summary>
        /// ダチョウが蹴ります。蹴って与えたダメージ値を返します。
        /// </summary>
        /// <returns>蹴って与えたダメージ値。</returns>
        public int Kick()
        {
            return 45;
        }

        /// <summary>
        /// 走る。
        /// </summary>
        /// <returns>走れた場合はTrue、失敗した場合はFalse。</returns>
        public bool Run()
        {
            isRunning = true;
            return true;
        }

        /// <summary>
        /// 走っている場合、止まる。既に止まっている場合は失敗する。
        /// </summary>
        /// <returns>停止出来た場合はTrue、失敗した場合はFalse。</returns>
        public bool Stop()
        {
            if (isRunning)
            {
                isRunning = false;
                return true;
            }
            else
            {
                return false;
            }
        }

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
