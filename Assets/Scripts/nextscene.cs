using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class nextscene : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;
    

    private void Start()
    {
        videoPlayer.Play();
        videoPlayer.loopPointReached += LoadNextScene;
    }

    private void LoadNextScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(1);
    }



}
