using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LevelVideo : MonoBehaviour
{
    public GameObject levelStart;
    public VideoPlayer player;

   public void StartLevelClicked()
    {
        levelStart.SetActive(false);
    }

    public void PlayAgainClicked()
    {
        player.Play();
    }
}
