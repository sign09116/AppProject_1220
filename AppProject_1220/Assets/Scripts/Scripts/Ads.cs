using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Ads : MonoBehaviour
{
    //private BannerView bannerView;
    void Start()
    {
        //抓取APPID
        string APPID = "ca-app-pub-1861098172776610~7389885492";
        MobileAds.Initialize(APPID);
        this.ShowAds();
    }
    private void ShowAds()
    {
        //抓取廣告模式的ID
        string BannerID = "ca-app-pub-1861098172776610/6082318119";
        //新增 橫幅(ID，尺寸，位置)
        BannerView BV = new BannerView(BannerID, AdSize.Banner, AdPosition.Bottom);
        //需求 建立 橫幅
        AdRequest AR = new AdRequest.Builder().Build();
        // 載入 橫幅
        BV.LoadAd(AR);
    }
}
