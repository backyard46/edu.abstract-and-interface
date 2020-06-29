using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    class Shimaenaga : ChoRui
    {
        /// <summary>
        /// 何も指定しないコンストラクター。個体名には「シマエナガ（鳥類）」が設定されます。
        /// </summary>
        public Shimaenaga()
        {
            // RaceName1は「鳥類クラス」で設定されているはずなのでここでは設定しません。
            this.RaceName2 = "シマエナガ";
            this.IndividualName = "シマエナガ（鳥類）";
            this.WingsCount = 2;
        }

        /// <summary>
        /// 個体名を指定するタイプのコンストラクター。
        /// </summary>
        /// <param name="name">シマエナガの個体名。</param>
        public Shimaenaga(string name)
        {
            this.RaceName2 = "シマエナガ";
            this.IndividualName = name;
            this.WingsCount = 2;
        }

        /// <summary>
        /// シマエナガが突きます。突き刺して与えたダメージ値を返します。
        /// </summary>
        /// <returns>突き刺して与えたダメージ値。</returns>
        public int Thrust()
        {
            return 10;
        }
    }
}
