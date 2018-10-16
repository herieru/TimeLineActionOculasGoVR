///<summary>
/// 概要：サンプルのためのボタンのUnitです。
/// UniRxの実験のためのものです。
/// 
/// 
///
/// <filename>
/// SampeleButtonUnit.cs
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
using UniRx;
using System;

public class SampeleButtonUnit : MonoBehaviour
{
    private Button button;


    public IObservable<SampeleButtonUnit> stream;

    public IDisposable stamp;

    public string Name
    {
        get
        {
            return this.gameObject.name;
        }
    }


	// Use this for initialization
	void Awake () 
	{
        button = GetComponent<Button>();
        if (null == button)
        {
            return;
        }
        stream = button.OnClickAsObservable().Select(_x => this);

        stamp = button.OnClickAsObservable().Select(_x => this).Subscribe();
    }

    // Update is called once per frame
    void Update () 
	{
		
	}


    private void onClick()
    {
        
    }

}
