using UnityEngine;
using GooglePlayGames;
public class GPAchievements : MonoBehaviour
{
    public void OpenAchievementsPanel()
    {
        Social.ShowAchievementsUI();
    }

    public void UpdateIncremental()
    {
        //PlayGamesPlatform.Instance.IncrementAchievement(GPGSIds.achievement_incremental, 1 ,null);
    }

    public void UnclockRegular()
    {
       //// Social.ReportProgress(GPGSIds.achievement_first_steps, 100f, null);
    }
}
