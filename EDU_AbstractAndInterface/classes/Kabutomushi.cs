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
    class Kabutomushi : KonchuRui, IEggCreatable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HachuRui"/> class.
        /// </summary>
        public Kabutomushi()
        {
            // カブトムシの基本設定を行う。
            this.RaceName2 = "カブトムシ";
            this.IndividualName = "カブトムシ（昆虫類）";
        }

        /// <summary>
        /// 個体名を設定するタイプのコンストラクター。
        /// </summary>
        /// <param name="name">個体名。</param>
        public Kabutomushi(string name)
        {
            // カブトムシの基本設定を行う。
            this.RaceName2 = "カブトムシ";
            this.IndividualName = name;
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

        public bool CreateEgg()
        {
            return true;
        }
    }
}
