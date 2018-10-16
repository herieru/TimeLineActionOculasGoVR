///<summary>
/// 概要：サンプルのスクリプトです。
/// UniRxを試すためのもので、Buttonのものをまとめる役割をもっています。
///
/// <filename>
/// SampleButtonmanager.cs
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
using UniRx;
using UnityEngine.UI;

public class SampleButtonmanager : MonoBehaviour
{

    public Text text;

    Subject<SampeleButtonUnit> subject;

    // Use this for initialization
    void Start()
    {
       


        SampeleButtonUnit[] _button_units = GetComponentsInChildren<SampeleButtonUnit>();

        
        for(int _i = 0;_i < _button_units.Length;_i++)
        {
             var _strem = _button_units[_i].stream.Subscribe(_unit => text.text = _unit.Name);
        }

    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
