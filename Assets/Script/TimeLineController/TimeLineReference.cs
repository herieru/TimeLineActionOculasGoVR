///<summary>
/// 概要：タイムラインの参照を保持するためのクラス
/// MonoBehaviorなどの機能的なものは使わない。
///
/// <filename>
/// TimeLineReference.cs
/// </filename>
///
/// <creatername>
/// 作成者：堀　明博
/// </creatername>
/// 
/// <address>
/// mailladdress:herie270714@gmail.com
/// </address>
///</summary>


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


namespace TimeLine
{

    public class TimeLineReference : MonoBehaviour
    {
        /// <summary>
        /// 最初に再生すべきタイムライン。
        /// </summary>
        [SerializeField]
        public PlayableDirector main_time_line;

        /// <summary>
        /// 最初に続くべきタイムライン
        /// </summary>
        [SerializeField]
        public PlayableDirector next_time_line;

        /// <summary>
        /// なんかエフェクト的な
        /// </summary>
        [SerializeField]
        public PlayableDirector effective_time_line;

        /// <summary>
        /// イベントチェックを行うためのオブジェクト
        /// </summary>
        [SerializeField]
        public GameObject check_enable_gameobject;
    }
}
