using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioSource rollingSound, bestScoreSound, buttonClick, gameSong, downSound, jumpSound, pointSound;
 
    public void RollingSoundStart()
    {
        rollingSound.Play();
    }
    public void BestScoreSound()
    {
        bestScoreSound.Play();
    }
    public void ButtonClick()
    {
        buttonClick.Play();
    }
    public void GameSong()
    {
        gameSong.Play();
    }
    public void DownSound()
    {
        downSound.Play();
    }
    public void JumpSound()
    {
        jumpSound.Play();
    }
    public void PointSound()
    {
        pointSound.Play();
    }

    public void RollingSoundStartStop()
    {
        rollingSound.Stop();
    }
    public void GameSongStop()
    {
        gameSong.Stop();
    }
}
