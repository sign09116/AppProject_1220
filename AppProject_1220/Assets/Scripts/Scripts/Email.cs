using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Email : MonoBehaviour
{
    #region 屬性
    /// <summary>
    /// 傳送信件目的地信箱
    /// </summary>
    string email;
    /// <summary>
    /// 信件主旨
    /// </summary>
    string subject;
    /// <summary>
    /// 傳送信件內容
    /// </summary>
    string body;
    #endregion
    #region 事件
    #endregion
    #region 方法
    /// <summary>
    /// 開起郵件傳送介面方法,必須安裝對應由軟體(PC)
    /// </summary>
    public void SendEmail()
    {

        email = "jduxxiug@gmail.com";
        subject = MyEscapeURL("My Subject");
        body = MyEscapeURL("My Body\r\nFull of non-escaped chars");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
    #endregion
}
