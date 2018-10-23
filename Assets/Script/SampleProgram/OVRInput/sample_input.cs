///<summary>
/// 概要：
///
/// <filename>
/// sample_input.cs
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

public class sample_input : MonoBehaviour 
{
    [SerializeField]
    Text text;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        string _display_str = "";
        bool[] _touch_bool = new bool[5];
        ///基本的にこの４つはとることができない。
        //上方向
        _touch_bool[0] = OVRInput.Get(OVRInput.Button.Up);
        // Down方向
        _touch_bool[1] = OVRInput.Get(OVRInput.Button.Down);
        // Left方向
        _touch_bool[2] = OVRInput.Get(OVRInput.Button.Left);
        // Right方向
        _touch_bool[3] = OVRInput.Get(OVRInput.Button.Right);

        //タッチパネルをクリック
        _touch_bool[4] = OVRInput.Get(OVRInput.Button.PrimaryTouchpad);

        Vector2 _touch_Pad  = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);


        for(int _i = 0;_i < 5;_i++)
        {
            _display_str += _touch_bool[_i] ? "有り" : "なし";
            _display_str += ":";
        }

        _display_str += "\n";
        _display_str += string.Format("座標 x:{0},y:{1}", _touch_Pad.x, _touch_Pad.y);


        if(null != text)
        {
            text.text = _display_str;
        }
    }
}
