using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : MonoBehaviour
{
    #region 屬性
    /// <summary>
    /// 是否可以關閉群組
    /// </summary>
    public bool _CanCloseGoup;
    /// <summary>
    /// 遮蓋按鈕物件
    /// </summary>
    public GameObject _Default;
    #endregion


    #region 事件


    #endregion

    #region 方法
    #region 打開群組視窗
    public void OpenGroup()
    {
        gameObject.SetActive(true);
        _CanCloseGoup = true;
        _Default.SetActive(true);
    }
    #endregion
    #region 關閉群組視窗
    public void CloseGroup()
    {
        if (_CanCloseGoup)
        {
            StartCoroutine(CanCloseGoup());
        }
    }
    IEnumerator CanCloseGoup()
    {
        yield return new WaitForSeconds(1);
        _Default.SetActive(false);
        gameObject.SetActive(false);




    }
    #endregion
    #endregion
}