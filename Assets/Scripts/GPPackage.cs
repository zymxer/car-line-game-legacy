using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GPPackage : MonoBehaviour
{
    public static PlayGamesPlatform platform;
    void Start()
    {
        if(platform == null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;

            platform = PlayGamesPlatform.Activate();
        }
        Social.Active.localUser.Authenticate(success =>
        {
            if(success)
            {
                Debug.Log("LIS");
            }
            else
            {
                Debug.Log("failed to log in");
            }
        });
    }


}
