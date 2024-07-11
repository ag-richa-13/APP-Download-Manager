using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DownloadManager : MonoBehaviour
{
    [SerializeField] private Button DownloadButton;
    [SerializeField] private TMP_Text progressText;
    [SerializeField] private Slider progressBar;
    private AndroidJavaObject currentActivity;

    void Start()
    {
        try
        {
            using (AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            }
            DownloadButton.onClick.AddListener(DownloadAPK);
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Exception in Start: " + ex.Message);
        }
    }

    public void DownloadAPK()
    {
        try
        {
            if (currentActivity != null)
            {
                var progressProxy = new DownloadProgressProxy(UpdateProgress);

                using (AndroidJavaClass apkDownloader = new AndroidJavaClass("com.myteam11.appdownloader_lib.ApkDownloader"))
                {
                    apkDownloader.CallStatic("onClickDownloadButton", currentActivity, progressProxy);
                }
            }
            else
            {
                Debug.LogError("Current Activity is null.");
            }
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Exception in DownloadAPK: " + ex.Message);
        }
    }

    private void UpdateProgress(int progress)
    {
        // Update progress text
        progressText.text = $"{progress}%";

        // Update progress bar
        progressBar.value = progress;
    }
}
