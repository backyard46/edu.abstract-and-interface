using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU_InheritPractice
{
    /// <summary>
    /// 卵を産めるというインターフェース。
    /// </summary>
    interface IEggCreatable
    {
        /// <summary>
        /// 卵を産む。
        /// </summary>
        /// <returns>成功したらTrue、失敗したらFalse。</returns>
        bool CreateEgg();
    }
}
