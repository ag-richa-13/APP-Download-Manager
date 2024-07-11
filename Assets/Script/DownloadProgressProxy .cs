using UnityEngine;

public class DownloadProgressProxy : AndroidJavaProxy
{
    private System.Action<int> onProgressUpdateCallback;

    public DownloadProgressProxy(System.Action<int> onProgressUpdate)
        : base("com.myteam11.appdownloader_lib.DownloadProgressCallback")
    {
        this.onProgressUpdateCallback = onProgressUpdate;
    }

    // This method name should exactly match the interface method
    public void onProgressUpdate(int progress)
    {
        onProgressUpdateCallback?.Invoke(progress);
    }
}
