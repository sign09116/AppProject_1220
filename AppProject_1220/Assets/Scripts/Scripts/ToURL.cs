using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToURL : MonoBehaviour
{
    #region 屬性

    /// <summary>
    /// 連結網址
    /// </summary>
    string[] Url;
    /// <summary>
    /// /按鈕編號
    /// </summary>
    int BottinID;
    /// <summary>
    /// 儲存按鈕ID
    /// </summary>
    string SaveBottinID = "SaveBottinID";
    [Header("連結網址按鈕")]
    public Button[] UrlButton;
    [Header("連結按鈕圖片")]
    public Sprite[] Urlspr;
    #endregion

    #region 事件
    private void Awake()
    {
        for (int i = 0; i < UrlButton.Length; i++)
        {
            UrlButton[i].GetComponent<Image>().sprite = Urlspr[i];
        }
    }
    private void Start()
    {
        #region 網址內容
        Url = new string[100];
        Url[0] = "";//
        Url[1] = "https://jduxxiug.pixnet.net/blog"; //好站連結
        Url[2] = "https://play.google.com/store/apps/details?id=ultimo.play.appla.jduxxiug&hl=zh-TW";//土地資訊網

        Url[3] = "https://maps.nlsc.gov.tw/";//國土測繪圖資
        Url[4] = "https://tradevan.land.net.tw/PTT_WEB/login.jsp";//關貿地政電傳
        Url[5] = "http://ep.land.nat.gov.tw/";//地政電傳謄本
        Url[6] = "http://easymap.land.moi.gov.tw/P02/";//便利民地籍圖
        Url[7] = "https://urban.planning.ntpc.gov.tw/NtpcURInfo/";//新北分區查詢
        Url[8] = "https://www.land.moi.gov.tw/chhtml/landvalue/42";//公告現值地價
        Url[9] = "https://luz.tcd.gov.tw/WEB/";//全國分區查詢
        Url[10] = "https://www.ibigfun.com/";//比房網查詢
        Url[11] = "https://www.foundi.info/";//房地資訊站

        Url[12] = "https://www.etax.nat.gov.tw/etwmain/front/ETW158W9";//土地增值稅
        Url[13] = "https://lvr.land.moi.gov.tw/homePage.action";//實價登錄查詢
        Url[14] = "https://develop.land.moi.gov.tw/Normal?ssl=true";//土地開發資訊
        Url[15] = "https://www2.land.ntpc.gov.tw/MASP/MASP15_NEW/MASP1501index.jsp";//新北市易找查
        Url[16] = "https://twur.cpami.gov.tw/zh/urban/govplan/0";//政府主導更新
        Url[17] = "https://uro.gov.taipei/cp.aspx?n=3C7DB2F1081E962B&s=10BABB411EC728C6";//新北市都市更新
        Url[18] = "http://www2.landntpc.gov.tw/MASP/MASP04/MASP0401index.jsp";//新北非都查詢
        Url[19] = "https://i.land.ntpc.gov.tw/webgis/";//新北房地查詢
        Url[20] = "http://gissrv4.sinica.edu.tw/gis/twhgis/";//台灣百年地圖

        Url[21] = "https://www.easytravel.com.tw/postid_search.asp";//郵遞區號
        Url[22] = "https://www.twfile.com/";//公司行號查詢
        Url[23] = "https://serv.swcb.gov.tw/";//山坡地查詢網
        Url[24] = "http://cpabm.cpami.gov.tw/twmap.jsp";//建築管理查詢
        Url[25] = "https://egis.moea.gov.tw/EGISWeb/";//經濟工廠資訊
        Url[26] = "https://www.geologycloud.tw/map/liquefaction/zh-tw";//土質液化查詢
        Url[27] = "http://cpabm.cpami.gov.tw/cers/SearchLicForm.do";//建築負責人
        Url[28] = "http://resim.land.moi.gov.tw/Agent/iamqry_11";//全省地政士網
        Url[29] = "https://resim.land.moi.gov.tw/priquery/iamqry_21";//全省經紀人網

        Url[30] = "";//
        Url[31] = "http://www.5b2f.com.tw/";//5B2F
        Url[32] = "";//
        #endregion
    }
    #endregion

    #region 方法
    #region  儲存按鈕ID
    public void saveButtonID(int id)
    {
        PlayerPrefs.SetInt(SaveBottinID, id);
        Debug.Log(id);
    }

    #endregion

    #region 開啟網頁
    public void OpenURL()
    {
        int i = PlayerPrefs.GetInt(SaveBottinID);
        //Debug.Log(i);
        Application.OpenURL(Url[i]);
    }
    #endregion
    #region 清除按鈕ID
    public void Claear()
    {
        PlayerPrefs.DeleteKey(SaveBottinID);
    }
    #endregion
    #endregion
}