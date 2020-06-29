using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    class Lifeform
    {
        /// <summary>
        /// デフォルトコンストラクター。特に何もしません。
        /// </summary>
        public Lifeform()
        {
        }

        // RaceName1用変数。
        private string raceName1 = string.Empty;

        /// <summary>
        /// 種族名1を設定、参照するプロパティ。たとえば「爬虫類」のような分類名を設定する。
        /// </summary>
        public string RaceName1
        {
            get { return raceName1; }
            set { raceName1 = value; }
        }

        // RaceName2用変数
        private string raceName2 = string.Empty;

        /// <summary>
        /// 種族名2を設定、参照するプロパティ。たとえば「ワニ」のような名称を設定する。
        /// </summary>
        public string RaceName2
        {
            get { return raceName2; }
            set { raceName2 = value; }
        }

        // IndividualName用変数。
        private string individualName = string.Empty;

        /// <summary>
        /// 個体名を保持するプロパティ。
        /// </summary>
        public string IndividualName
        {
            get { return individualName; }
            set { individualName = value; }
        }

        // FeetCountプロパティ用変数。
        private int legsCount = 0;

        /// <summary>
        /// 足の本数を設定、参照するプロパティ。
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">FeetCount - 足の数は0以上である必要があります。</exception>
        public int LegsCount
        {
            get { return legsCount; }
            set
            {
                if (value>=0)
                {
                    legsCount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("FeetCount", "足の数は0以上である必要があります。");
                }
            }
        }

        private int maxLifePoint = 0;

        public int MaxLifePoint
        {
            get { return maxLifePoint; }
            set
            {
                if (value >=0)
                {
                    maxLifePoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("MaxLifePoint", "生命力ポイント最大値は0以上である必要があります。");
                }
            }

        }

        // LifePointプロパティ用変数。
        private int lifePoint = 0;

        /// <summary>
        /// 生命力ポイント（HP）を設定、参照するプロパティ。
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">LifePoint - 生命力ポイントは0以上である必要があります。</exception>
        public int LifePoint
        {
            get { return lifePoint; }
            set
            {
                if (value>=0)
                {
                    lifePoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("LifePoint", "生命力ポイントは0以上である必要があります。");
                }
            }
        }

        /// <summary>
        /// 引数で指定した数値分、生命力ポイントを回復させる
        /// </summary>
        /// <param name="lifePoint">回復させる生命力ポイント。</param>
        /// <returns>回復後の生命力ポイント。</returns>
        public int Heal(int healPoint)
        {
            lifePoint += healPoint;
            if (lifePoint>maxLifePoint)
            {
                // 回復した結果最大値を超えるようなら現在の生命力ポイントを最大値に設定する。
                lifePoint = maxLifePoint;
            }
            return lifePoint;
        }

        /// <summary>
        /// 引数で指定した数値分、生命力ポイントを減らす。
        /// </summary>
        /// <param name="damagePoint">減らす生命力ポイント。</param>
        /// <returns>減らした後の生命力ポイント。</returns>
        public int Damage(int damagePoint)
        {
            lifePoint -= damagePoint;
            if (lifePoint<0)
            {
                // ダメージを与えた結果0を下回るようなら現在の生命力ポイントをゼロにする。
                lifePoint = 0;
            }
            return lifePoint;
        }

        /// <summary>
        /// 死亡する。生命力ポイントがゼロになる。
        /// </summary>
        public void Die()
        {
            lifePoint = 0;
        }

        /// <summary>
        /// 現在のオブジェクトの状態を文字列で返します。
        /// </summary>
        /// <returns>
        /// 現在のオブジェクト状態を表す文字列。
        /// </returns>
        public override string ToString()
        {
            string result = string.Empty;

            result += this.RaceName1 + "\r\n";
            result += this.RaceName2 + "\r\n";
            result += this.IndividualName + "\r\n";
            result += "HP:" + this.LifePoint.ToString() + "\r\n";
            result += "Legs:" + this.LegsCount.ToString() + "\r\n";

            return result;
        }

    }
}
