using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    class Wani: HachuRui
    {
        /// <summary>
        /// 何も指定しないコンストラクター。個体名には「ワニ（爬虫類）」が設定されます。
        /// </summary>
        public Wani()
        {
            // RaceName1は「爬虫類クラス」で設定されているはずなのでここでは設定しません。
            this.RaceName2 = "ワニ";
            this.IndividualName = "ワニ（爬虫類）";
        }

        /// <summary>
        /// 個体名を指定するタイプのコンストラクター。
        /// </summary>
        /// <param name="name">ワニの個体名。</param>
        public Wani(string name)
        {
            this.RaceName2 = "ワニ";
            this.IndividualName = name;
        }

        /// <summary>
        /// ワニが噛みます。噛んで与えたダメージ値を返します。
        /// </summary>
        /// <returns>噛んで与えたダメージ値。</returns>
        public int Bite()
        {
            return 50;
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
