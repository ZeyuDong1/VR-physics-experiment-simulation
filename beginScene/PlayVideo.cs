using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour {

	public VideoPlayer videoPlayer;
	
	public void PlayButton()
	{
		videoPlayer.Play();
	}
	
	public void StopButton()
	{
		videoPlayer.Stop();
	}
	
	public void ReplayButton()
	{
		videoPlayer.Pause();
	}
}
