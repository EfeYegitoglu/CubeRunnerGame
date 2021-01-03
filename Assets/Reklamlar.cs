using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;


public class Reklamlar : MonoBehaviour
{
    private InterstitialAd interstitial;
    static Reklamlar reklam;



    void Start()
    {
        if (reklam==null)
        {
            DontDestroyOnLoad(gameObject);
            reklam = this;

            //1. aşama
            MobileAds.Initialize(initStatus => { });

            //2.aşama
            #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/1033173712";
            #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/4411468910";
            #else
            string adUnitId = "unexpected_platform";
            #endif

            // Initialize an InterstitialAd.
            this.interstitial = new InterstitialAd(adUnitId);

            AdRequest request = new AdRequest.Builder()
            .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")
            .Build();
            this.interstitial.LoadAd(request);
        }
        else
        {
            Destroy(gameObject);
        }
        

        
    }

    
    public void ReklamGoster()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
        reklam = null;
        Destroy(gameObject);
    }
}
