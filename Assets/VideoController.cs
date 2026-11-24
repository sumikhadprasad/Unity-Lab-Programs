using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    [Header("Keyboard Controls (for testing)")]
    public KeyCode playPauseKey = KeyCode.Space;
    public KeyCode stopKey = KeyCode.S;

    void Start()
    { 
        if (videoPlayer != null)
            videoPlayer.Play();
    }

    void Update()
    {
        if (videoPlayer == null) return;

        // Play / Pause toggle with Space
        if (Input.GetKeyDown(playPauseKey))
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                // If you want it to always restart from beginning when pressing Space:
                // videoPlayer.time = 0;
                videoPlayer.Play();
            }
        }

        // Stop with S
        if (Input.GetKeyDown(stopKey))
        {
            StopVideo();
        }
    }

    public void PlayVideo()
    {
        if (videoPlayer == null) return;

        // Uncomment if you want it to always restart from beginning:
        // videoPlayer.time = 0;

        videoPlayer.Play();
    }

    public void PauseVideo()
    {
        if (videoPlayer == null) return;
        videoPlayer.Pause();
    }

    public void StopVideo()
    {
        if (videoPlayer == null) return;
        videoPlayer.Stop();
    }
}