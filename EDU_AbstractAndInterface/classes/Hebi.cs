using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    class Hebi: HachuRui
    {
        /// <summary>
        /// 何も指定しないコンストラクター。個体名には「ワニ（爬虫類）」が設定されます。
        /// </summary>
        public Hebi()
        {
            // RaceName1は「爬虫類クラス」で設定されているはずなのでここでは設定しません。
            this.RaceName2 = "ヘビ";
            this.IndividualName = "ヘビ（爬虫類）";
            this.LegsCount = 0;
            hasPoison=DecidePoisonAbility();
        }

        /// <summary>
        /// 個体名を指定するタイプのコンストラクター。
        /// </summary>
        /// <param name="name">ヘビの個体名。</param>
        public Hebi(string name)
        {
            this.RaceName2 = "ヘビ";
            this.IndividualName = name;
            this.LegsCount = 0;
            hasPoison = DecidePoisonAbility();
        }

        // HasPoisonプロパティ用変数。
        private bool hasPoison = false;

        /// <summary>
        /// 毒の有無設定、取得用プロパティ。
        /// </summary>
        public Boolean HasPoison
        {
            get { return hasPoison; }
            set { hasPoison = value; }
        }

        /// <summary>
        /// 毒の有無をランダムに決める。コンストラクターで呼び、毒の有無を決める。
        /// </summary>
        /// <returns>毒がある:True / 毒が無い:False</returns>
        private bool DecidePoisonAbility()
        {
            int result = new Random().Next(2);
            if (result==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// ヘビが噛みます。噛んで与えたダメージ値を返します。
        /// </summary>
        /// <returns>噛んで与えたダメージ値。</returns>
        public int Bite()
        {
            return 20;
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
            if (this.HasPoison)
            {
                result += "毒あり" + "\r\n";
            }
            return result;
        }
    }
}
