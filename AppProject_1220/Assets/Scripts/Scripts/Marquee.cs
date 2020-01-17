using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marquee : MonoBehaviour
{
    #region 屬性
    [Header("跑馬燈內容文字")]
    public string Marqueeinfo;
    public RectTransform _Marquee;
    [Range(0, 100)]
    public float Speed;
    /// <summary>
    /// 跑馬燈臨界位置
    /// </summary>
    float L;
    public float Now;
    //public RectTransform mask;
    #endregion

    #region 事件

    private void Start()
    {
        GetComponent<Text>().text = Marqueeinfo;

        L = _Marquee.rect.width * -1;
    }
    private void Update()
    {//向左移動
        _Marquee.Translate(Vector3.left * Speed);
        //當前X的絕對位置
        Now = _Marquee.localPosition.x;
        //跑馬燈向右移動(N個單位)
        if (Now < L)
        {
            _Marquee.Translate(_Marquee.rect.width * 3, 0, 0);
        }
    }


    #endregion

    #region 方法
    #endregion

}
