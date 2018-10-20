///<summary>
/// 概要：隕石群の回転を行うためのスクリプトです。
/// 作業スピードに合わせた速度変化を行うためのものです。
///
/// <filename>
/// CommetRolling.cs
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

public class CommetRolling : MonoBehaviour 
{
    //この辺の数値は回っている速度を表しており、数字自体は特に意味のない数字
    private readonly float x_rod = 0.2f;
    private readonly float y_rod = 4f;
    private readonly float z_rod = 2.3f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        Quaternion _quaternion = transform.rotation;
        _quaternion = _quaternion * Quaternion.Euler(x_rod, y_rod, z_rod);
        transform.rotation = _quaternion;
	}
}
