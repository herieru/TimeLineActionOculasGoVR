///<summary>
/// 概要：このスクリプトは、Activeの間にチェックの関数が呼ばれたら、
/// trueを返すそれ以外で呼ばれたら、falseを返す？
///
/// <filename>
/// sampleEventTrigger.cs
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

public class sampleEventTrigger : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


    /// <summary>
    /// ヒエラルキー上で、アクティブかどうかのチェックを行う。
    /// </summary>
    /// <returns></returns>
    public bool CheackActive()
    {
        return this.gameObject.activeInHierarchy;

    }
}
