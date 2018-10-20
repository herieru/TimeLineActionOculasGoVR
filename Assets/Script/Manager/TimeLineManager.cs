///<summary>
/// 概要：タイムラインの管理を行うための窓口的な役割になってくれたらうれしい。
/// ここでは、タイムラインでの基本的な呼び出しを行う
/// なんならカオスコードにしてもいいとは思ってはいる。
///
/// <filename>
/// TimeLineManager.cs
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
    public class TimeLineManager : MonoBehaviour
    {
        [SerializeField]
        private TimeLineReference reference;

        /// <summary>
        /// ひとまず適当に作ったもの
        /// </summary>
        [SerializeField]
        PlayableAsset right_move;

        // ひとまず適当
        [SerializeField]
        PlayableAsset left_move;

        [SerializeField]
        private PlayableDirector left_move_director;


        [SerializeField]
        private PlayableDirector right_move_director;

        public void Update()
        {
            if( 
                //PC　と　Oculas用のTrigger用のボタン
                Input.GetKeyDown(KeyCode.F) ||
                OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)
                )
            {
              // reference.next_time_line.playableAsset = right_move;
                //動的にバインド


                reference.next_time_line.Play(right_move, DirectorWrapMode.Hold);
                //UnityEditor.EditorApplication.isPaused = true;
                //left_move_director.Play();
            }

            if(
                Input.GetKeyDown(KeyCode.G)
                )
            {

                reference.next_time_line.Play(left_move, DirectorWrapMode.Hold);
               // right_move_director.Play();
            }
        }
    }
}
