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

        /// <summary>
        /// 左右にずれると足したり引いたりする
        /// </summary>
        int _center_ancher_point = 0;

        public void Update()
        {
            Vector2 _touch_pos = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
            //右
            if ( 
                //PC　と　Oculas用のTrigger用のボタン
                Input.GetKeyDown(KeyCode.F) ||

                (OVRInput.Get(OVRInput.Button.PrimaryTouchpad) &&
                (0.3f < _touch_pos.x  && -0.5f < _touch_pos.y && _touch_pos.y < 0.5f))
                )
            {
                reference.next_time_line.Play(right_move, DirectorWrapMode.Hold);
                _center_ancher_point--;
            }

            //左
            if(
                Input.GetKeyDown(KeyCode.G)||

                ((OVRInput.Get(OVRInput.Button.PrimaryTouchpad)) && 
                _touch_pos.x < -0.3f && -0.5f < _touch_pos.y && _touch_pos.y < 0.5f)
                )
            {
                reference.next_time_line.Play(left_move, DirectorWrapMode.Hold);
                _center_ancher_point++;
            }

            Debug.Log("center_Anche:" + _center_ancher_point);

            if(false == (-2 <= _center_ancher_point && _center_ancher_point <= 2))
            {
                //GameOver
                reference.main_time_line.Pause();
            }
        }
    }
}
