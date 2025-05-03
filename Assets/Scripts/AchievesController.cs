using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;

public class AchievesController : MonoBehaviour
{
    public bool[] Achieves = new bool[40];

    public GameObject ScoreController;
    public GameObject MoneyController;
    public int AchievesAmount = 0;

    public int TotalScore;
    public int TotalMoney;
    public int FlipsAmount;
    public int TimeInFly;
    public int TotalDeaths;
    public int DeathInARaw;
    public int Car2;
    public int Car3;
    public int Car4;
    public int Car5;
    public int Car6;

    public bool Car2One;
    public bool Car3One;
    public bool Car4One;
    public bool Car5One;
    public int AchievesTotal = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreController = GameObject.FindWithTag("ScoreController");
        MoneyController = GameObject.FindWithTag("MoneyController");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FlipsAmount = PlayerPrefs.GetInt("FlipsAmount");
        TotalScore = PlayerPrefs.GetInt("TotalScore");
        TotalMoney = PlayerPrefs.GetInt("TotalMoney");
        TotalDeaths = PlayerPrefs.GetInt("DetahAmount");
        TimeInFly = PlayerPrefs.GetInt("TimeInFly");
        DeathInARaw = PlayerPrefs.GetInt("ZeroPointsInARaw");
        Car2 = PlayerPrefs.GetInt("Car2Bought");
        Car3 = PlayerPrefs.GetInt("Car3Bought");
        Car4 = PlayerPrefs.GetInt("Car4Bought");
        Car5 = PlayerPrefs.GetInt("Car5Bought");
        Car6 = PlayerPrefs.GetInt("Car6Bought");
        if (TotalScore >= 10 && Achieves[0] == false)
        {
            AchievesTotal++;
            Achieves[0] = true;
            Social.ReportProgress(GPGSIds.achievement_10_points, 100f, null);
        }

        if (TotalScore >= 25 && Achieves[1] == false)
        {
            AchievesTotal++;
            Achieves[1] = true;
            Social.ReportProgress(GPGSIds.achievement_25_points, 100f, null);
        }

        if (TotalScore >= 50 && Achieves[2] == false)
        {
            AchievesTotal++;
            Achieves[2] = true;
            Social.ReportProgress(GPGSIds.achievement_50_points, 100f, null);
        }

        if (TotalScore >= 100 && Achieves[3] == false)
        {
            AchievesTotal++;
            Achieves[3] = true;
            Social.ReportProgress(GPGSIds.achievement_100_points, 100f, null);
        }

        if (TotalScore >= 250 && Achieves[4] == false)
        {
            AchievesTotal++;
            Achieves[4] = true;
            Social.ReportProgress(GPGSIds.achievement_250_points, 100f, null);
        }

        if (TotalScore >= 500 && Achieves[5] == false)
        {
            AchievesTotal++;
            Achieves[5] = true;
            Social.ReportProgress(GPGSIds.achievement_500_points, 100f, null);
        }

        if (TotalScore >= 1000 && Achieves[6] == false)
        {
            AchievesTotal++;
            Achieves[6] = true;
            Social.ReportProgress(GPGSIds.achievement_1000_points, 100f, null);
        }

        if (TotalScore >= 10000 && Achieves[7] == false)
        {
            AchievesTotal++;
            Achieves[7] = true;
            Social.ReportProgress(GPGSIds.achievement_10000_points, 100f, null);
        }


        if (TotalMoney >= 100 && Achieves[8] == false)
        {
            AchievesTotal++;
            Achieves[8] = true;
            Social.ReportProgress(GPGSIds.achievement_100_coins, 100f, null);
        }

        if (TotalMoney >= 1000 && Achieves[9] == false)
        {
            AchievesTotal++;
            Achieves[9] = true;
            Social.ReportProgress(GPGSIds.achievement_1000_coins, 100f, null);
        }

        if (TotalMoney >= 10000 && Achieves[10] == false)
        {
            AchievesTotal++;
            Achieves[10] = true;
            Social.ReportProgress(GPGSIds.achievement_10000_coins, 100f, null);
        }

        if (TotalMoney >= 50000 && Achieves[11] == false)
        {
            AchievesTotal++;
            Achieves[11] = true;
            Social.ReportProgress(GPGSIds.achievement_50000_coins, 100f, null);
        }


        if (TimeInFly >= 5 && Achieves[12] == false)
        {
            AchievesTotal++;
            Achieves[12] = true;
            Social.ReportProgress(GPGSIds.achievement_5x_air_time, 100f, null);
        }

        if (TimeInFly >= 10 && Achieves[13] == false)
        {
            AchievesTotal++;
            Achieves[13] = true;
            Social.ReportProgress(GPGSIds.achievement_10x_air_time, 100f, null);
        }

        if (TotalDeaths >= 5 && Achieves[14] == false)
        {
            AchievesTotal++;
            Achieves[14] = true;
            Social.ReportProgress(GPGSIds.achievement_lose_5_times, 100f, null);
        }

        if (TotalDeaths >= 10 && Achieves[15] == false)
        {
            AchievesTotal++;
            Achieves[15] = true;
            Social.ReportProgress(GPGSIds.achievement_lose_10_times, 100f, null);
        }

        if (TotalDeaths >= 25 && Achieves[16] == false)
        {
            AchievesTotal++;
            Achieves[16] = true;
            Social.ReportProgress(GPGSIds.achievement_lose_25_times, 100f, null);
        }


        if (DeathInARaw >= 5 && Achieves[17] == false)
        {
            AchievesTotal++;
            Achieves[17] = true;
            Social.ReportProgress(GPGSIds.achievement_5x_big_lose, 100f, null);
        }

        if (DeathInARaw >= 10 && Achieves[18] == false)
        {
            AchievesTotal++;
            Achieves[18] = true;
            Social.ReportProgress(GPGSIds.achievement_10x_big_lose, 100f, null);
        }


        if (FlipsAmount >= 1 && Achieves[19] == false)
        {
            AchievesTotal++;
            Achieves[19] = true;
            Social.ReportProgress(GPGSIds.achievement_1_flip, 100f, null);
        }

        if (FlipsAmount >= 10 && Achieves[20] == false)
        {
            AchievesTotal++;
            Achieves[20] = true;
            Social.ReportProgress(GPGSIds.achievement_10_flips, 100f, null);
        }


        if(Car2 == 1 && Achieves[21] == false)
        {
            Car2One = true;
            AchievesTotal++;
            Achieves[21] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_buggy, 100f, null);
        }
        /*if(Car2 == 0 && Car2One == true && Achieves[29] == false)
        {
            AchievesTotal++;
            Achieves[29] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_buggy, 100f, null);
        } */

        if (Car3 == 1 && Achieves[22] == false)
        {
            Car3One = true;
            AchievesTotal++;
            Achieves[22] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_maston_artin, 100f, null);
        }
        /*if (Car3 == 0 && Car3One == true && Achieves[30] == false)
        {
            AchievesTotal++;
            Achieves[30] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_maston_artin, 100f, null);
        }*/

        if (Car4 == 1 && Achieves[23] == false)
        {
            Car4One = true;
            AchievesTotal++;
            Achieves[23] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_suv, 100f, null);
        }
        /*if (Car4 == 0 && Car4One == true && Achieves[31] == false)
        {
            AchievesTotal++;
            Achieves[31] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_suv, 100f, null);
        }*/

        if (Car5 == 1 && Achieves[24] == false)
        {
            Car5One = true;
            AchievesTotal++;
            Achieves[24] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_beta_juliet, 100f, null);
        }
        /*if (Car5 == 0 && Car5One == true && Achieves[32] == false)
        {
            AchievesTotal++;
            Achieves[32] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_beta_juliet, 100f, null);
        } */


        if (Car2 == 1 && Car3 == 1 && Car4 == 1 && Car5 == 1 && Car6 == 1 && Achieves[25] == false)
        {
            AchievesTotal++;
            Achieves[25] = true;
            Social.ReportProgress(GPGSIds.achievement_buy_all_cars, 100f, null);
        }

        if(AchievesTotal >= 5 && Achieves[26] == false)
        {
            Achieves[26] = true;
            AchievesTotal++;
            Social.ReportProgress(GPGSIds.achievement_5_achievements, 100f, null);
        }
        if (AchievesTotal >= 15 && Achieves[27] == false)
        {
            Achieves[27] = true;
            AchievesTotal++;
            Social.ReportProgress(GPGSIds.achievement_15_achievements, 100f, null);
        }
        if (AchievesTotal >= 28 && Achieves[28] == false)
        {
            Achieves[28] = true;
            AchievesTotal++;
            Social.ReportProgress(GPGSIds.achievement_all_achievements, 100f, null);
        }
    }
}
