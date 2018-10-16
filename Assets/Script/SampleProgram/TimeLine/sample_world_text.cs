///<summary>
/// 概要：テキストを反映するだけのためのもの
///
/// <filename>
/// sample_world_text.cs
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
using UnityEngine.UI;

public class sample_world_text : MonoBehaviour 
{

    [SerializeField]
    private Text text;


    [SerializeField]
    private SampleTimelineDirector sample_timeline_director;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(null == text || null == sample_timeline_director)
        {
            return;
        }

        text.text = sample_timeline_director.is_win_select ? "win" : "lose";
	}
}
