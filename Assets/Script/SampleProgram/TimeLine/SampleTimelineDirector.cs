///<summary>
/// 概要：このクラスは、TimeLineDirectorの再生を変更するための装置です。
/// 
///
/// <filename>
/// SampleTimelineDirector.cs
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
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityEngine.UI;

public class SampleTimelineDirector : MonoBehaviour
{
    public sampleEventTrigger cheakEvent;

    //最初に再生を行うためのDirector
    public PlayableDirector first_time_line;

    //
    public PlayableDirector win_ver;

    //
    public PlayableDirector lose_ver;


    public PlayableAsset win;

    public PlayableAsset lose;

    public Text text;


    public bool is_win_select;

    private void OnGUI()
    {
        if (null != first_time_line)
        {
            GUILayout.TextField("length :" + first_time_line.duration);
            GUILayout.TextField("now_time:" + first_time_line.time);
        }

        GUILayout.Label("is_win_select:" + is_win_select);
    }


    // Use this for initialization
    void Start()
    {
        is_win_select = true;

        first_time_line.stopped += CheakEvent;
    }

    // Update is called once per frame
    void Update()
    {
        if(cheakEvent.CheackActive())
        {
            //text.text = "ok";
        }
        else
        {
           // text.text = "ng";
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            is_win_select = true;
            if (cheakEvent.CheackActive())
            {
                text.text += "チェックできてる";
            }
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            is_win_select = false;
            if (false == cheakEvent.CheackActive())
            {
                text.text += "チェック体制は動いている";
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            first_time_line.Stop();
            first_time_line.time = 0;
            first_time_line.Play();
        }        

        //OculasGo用のキー
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            is_win_select = !is_win_select;

            if(cheakEvent.CheackActive())
            {
                text.text += "チェックできてる";
            }
        }

        if(OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
            first_time_line.time = 0;
            first_time_line.Play();
        }
    }

    /// <summary>
    /// イベント発生をチェックする。 Endによる発注
    /// </summary>
    public void CheakEvent(PlayableDirector _director)
    {
        text.text = "イベントチェックに来たよ";
        Debug.Log("EventCheakにきたよ");
        first_time_line.Stop();
        if(is_win_select)
        {
            //win_ver.Play(win,DirectorWrapMode.Hold);
            win_ver.playableAsset = win;           
            win_ver.stopped += a_part;
            win_ver.Play();
        }
        else
        {
            lose_ver.Play(lose,DirectorWrapMode.None);
        }
       // EndAnimation();
    }

    public void a_part(PlayableDirector _director)
    {
        Debug.Log("a_partが呼ばれたよ");
        text.text = "a_part呼ばれた";
        first_time_line.time = 0;
        first_time_line.Play();
    }

    public void checkevent()
    {
        text.text = "イベントチェックに来たよ";
        Debug.Log("EventCheakにきたよ");
        first_time_line.Stop();
        if (is_win_select)
        {
            win_ver.Play(win, DirectorWrapMode.Hold);
            first_time_line.time = 0;
            first_time_line.Play();
        }
        else
        {
            lose_ver.Play(lose, DirectorWrapMode.None);
        }
        // EndAnimation();
    }

    private void EndAnimation()
    {
        first_time_line.time = first_time_line.duration;
    }


}
