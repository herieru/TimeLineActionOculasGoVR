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

public class SampleTimelineDirector : MonoBehaviour
{
    //最初に再生を行うためのDirector
    public PlayableDirector first_time_line;

    //
    public PlayableDirector win_ver;

    //
    public PlayableDirector lose_ver;


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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            is_win_select = true;
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            is_win_select = false;
        }

        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            is_win_select = !is_win_select;
        }
    }

    /// <summary>
    /// イベント発生をチェックする。
    /// </summary>
    public void CheakEvent()
    {
        Debug.Log("EventCheakにきたよ");
        if(is_win_select)
        {
            Debug.Log("Winがながれるはず");
            win_ver.enabled = true;
            win_ver.time = 0;
            win_ver.Play();
        }
        else
        {
            Debug.Log("Loseが流れるはず");
            lose_ver.enabled = true;
            lose_ver.time = 0;
            lose_ver.Play();
        }
    }
}
