///<summary>
/// タイムラインの参照に対して、色々アクセスして、指示を出すためのものです。
/// 例えば、特定のDirectorに対して、このタイムラインを再生してと指示を出す人がいて
/// それに対して、ここがそれに必要なものはと参照を持っていて、具体的に処理していくクラスです。
/// 
///
/// <filename>
/// TimeLineController.cs
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
namespace TimeLine
{
    public enum AccessDirector
    {
        Main,
        Next,
        Effect
    }


    public class TimeLineController
    {
        private TimeLineReference reference;

        public TimeLineController(TimeLineReference _reference)
        {
            reference = _reference;
        }

        /// <summary>
        /// イベントをチェックするためのオブジェクトに対して、現在
        /// イベント中かのチェックを行う。
        /// </summary>
        /// <returns></returns>
        public bool CheakEventTime()
        {
            if(null == reference)
            {
                return false;
            }

            if(reference.check_enable_gameobject)
            {
                Debug.LogWarning("Dont Set EventCheakObject");
                return false;
            }


            return reference.check_enable_gameobject.activeInHierarchy;
        }


    

    }
}
