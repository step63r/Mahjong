using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minato.Mahjong
{
    /// <summary>
    /// 牌一式を格納するクラス
    /// </summary>
    public class Hai
    {
        /// <summary>
        /// １つの牌は数値と文字列で定義される
        /// </summary>
        public Tuple<int, string> Item;

        /// <summary>
        /// 牌の実態定義
        /// </summary>
        public static readonly ReadOnlyDictionary<Tuple<int, string>, string> OneSet = new ReadOnlyDictionary<Tuple<int, string>, string>(
            new Dictionary<Tuple<int, string>, string>()
            {
                { Tuple.Create(1, "m"), "一萬"},
                { Tuple.Create(2, "m"), "二萬"},
                { Tuple.Create(3, "m"), "三萬"},
                { Tuple.Create(4, "m"), "四萬"},
                { Tuple.Create(5, "m"), "五萬"},
                { Tuple.Create(6, "m"), "六萬"},
                { Tuple.Create(7, "m"), "七萬"},
                { Tuple.Create(8, "m"), "八萬"},
                { Tuple.Create(9, "m"), "九萬"},
                { Tuple.Create(1, "s"), "一索"},
                { Tuple.Create(2, "s"), "二索"},
                { Tuple.Create(3, "s"), "三索"},
                { Tuple.Create(4, "s"), "四索"},
                { Tuple.Create(5, "s"), "五索"},
                { Tuple.Create(6, "s"), "六索"},
                { Tuple.Create(7, "s"), "七索"},
                { Tuple.Create(8, "s"), "八索"},
                { Tuple.Create(9, "s"), "九索"},
                { Tuple.Create(1, "p"), "一筒"},
                { Tuple.Create(2, "p"), "二筒"},
                { Tuple.Create(3, "p"), "三筒"},
                { Tuple.Create(4, "p"), "四筒"},
                { Tuple.Create(5, "p"), "五筒"},
                { Tuple.Create(6, "p"), "六筒"},
                { Tuple.Create(7, "p"), "七筒"},
                { Tuple.Create(8, "p"), "八筒"},
                { Tuple.Create(9, "p"), "九筒"},
                { Tuple.Create(1, "k"), "東"},
                { Tuple.Create(2, "k"), "南"},
                { Tuple.Create(3, "k"), "西"},
                { Tuple.Create(4, "k"), "北"},
                { Tuple.Create(1, "g"), "白"},
                { Tuple.Create(2, "g"), "發"},
                { Tuple.Create(3, "g"), "中"}
            }
        );
    }
}
