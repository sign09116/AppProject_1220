using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScenes : MonoBehaviour
{
    #region 屬性
    /// <summary>
    /// 儲存按鈕ID
    /// </summary>
    string SaveBottinID = "SaveBottinID";
    #endregion




    #region 事件


    #endregion

    #region 方法


    #region 進入新頁面
    public void _Openscenes()
    {
        int i = PlayerPrefs.GetInt(SaveBottinID);
        Application.LoadLevel(i);
    }
    #endregion
    #region 返回首頁
    public void ReturnMenu()
    {
        Application.LoadLevel(0);
    }
    #endregion
    #endregion
}
