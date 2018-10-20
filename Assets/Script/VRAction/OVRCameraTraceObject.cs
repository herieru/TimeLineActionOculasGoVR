///<summary>
/// 概要：このプログラム特定のObjectに対して、位置の追従を完全に行うためのものです。
/// 
///
/// <filename>
/// OVRCameraTraceObject.cs
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

public class OVRCameraTraceObject : MonoBehaviour 
{

    [SerializeField]
    Transform target_trace;

    private readonly Vector3 offset_pos = new Vector3(0, 0.5f, 0.1f);

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        if(null == target_trace)
        {
            return;
        }

        var _my_pos = this.transform.position;
        _my_pos = target_trace.position;

        this.transform.position = _my_pos + offset_pos;


	}
}
