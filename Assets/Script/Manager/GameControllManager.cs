///<summary>
/// 概要：このクラスは、GameManagerです。
///
/// <filename>
/// GameControllManager.cs
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
using TimeLine;

public class GameControllManager : MonoBehaviour 
{

    IObservable<Unit> obserbable;

    [SerializeField]
    private CollisionNotice[] commet_notice;

    [SerializeField]
    private TimeLineManager timeline_manager;

    private Subject<Unit> commet_observe;
    private Subject<GameObject> commet_from_notice;

	// Use this for initialization
	void Start () 
	{
        commet_from_notice = new Subject<GameObject>();
        commet_from_notice.Subscribe
            (
            _timline_notice=>
                {
                    if(null != timeline_manager)
                    {
                        timeline_manager.commet_hit();
                    }
                }
            );

        commet_observe = new Subject<Unit>();
        commet_observe.Do(_notice =>
        {
            if (null != timeline_manager)
            {
                timeline_manager.commet_hit();
            }
        }
        ).Subscribe();

        for(int _i = 0; _i <  commet_notice.Length;_i++)
        {
            commet_notice[_i].SetNotice(commet_from_notice);
        }
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
