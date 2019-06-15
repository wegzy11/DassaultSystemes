using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour
{
    //Resource: https://www.youtube.com/watch?v=ffJoBfj41GU
    //Resource: https://docs.unity3d.com/ScriptReference/Video.VideoPlayer.html

    bool isPlaying = true;
    public VideoPlayer video;
    public GameObject nextColorButton;

    private void Start()
    {
        //This calls the funtion when video loops
        video.loopPointReached += loopPointReached;
    }

    public void ToggleVideo()
    {
        isPlaying = !isPlaying;

        if (isPlaying)
        {
            video.Play();
            GetComponentInChildren<Text>().text = "Pause";
        }
        else
        {
            video.Pause();
            GetComponentInChildren<Text>().text = "Play";
        }

    }


    void loopPointReached(VideoPlayer vp)
    {
        //calls function on nextColorButton to change material to yellow
        nextColorButton.GetComponent<NextColorButtonScript>().OnVideoLoop();
    }


}


