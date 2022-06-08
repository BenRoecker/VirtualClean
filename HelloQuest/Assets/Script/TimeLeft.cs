using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLeft : MonoBehaviour
{
    public Text m_timer;

    public int m_timeExperience;

    public GameObject m_buttonStart;

    public GameObject m_finalScore;

    public Text m_scoreText;

    public string m_nameScene;

    private int m_timeLeft;

    public void Start()
    {
        m_timeLeft = PlayerPrefs.GetInt("Timer");

        m_timeExperience = PlayerPrefs.GetInt("Timer");

        //m_timeLeft = m_timeExperience;

        StartPlay();
    }

    public void StartPlay()
    {
        StartCoroutine(StartExperience());

        StartCoroutine(TimerLive());
    }

    IEnumerator StartExperience()
    {
        ScoreManager.m_instance.m_score = 0;
        ScoreManager.m_instance.UpdateScore(0);
        yield return new WaitForSeconds(m_timeExperience);
        m_finalScore.SetActive(true);
        m_scoreText.text = "You did : " + ScoreManager.m_instance.m_score.ToString() + " in " + m_timeExperience.ToString() + " seconds !";
        StartCoroutine(BackToStartScene());
    }

    IEnumerator TimerLive()
    {
        yield return new WaitForSeconds(1);
        m_timeLeft -= 1;
        Debug.Log(m_timeLeft.ToString());
        m_timer.text = TimeSpan.FromSeconds(m_timeLeft).ToString();
        if(m_timeLeft > 0)
        {
            StartCoroutine(TimerLive());
        }
    }

    IEnumerator BackToStartScene()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(m_nameScene);
    }
}
