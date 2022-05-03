using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour
{
    public Text m_timer;

    public int m_timeExperience;

    public GameObject m_buttonStart;

    public GameObject m_finalScore;

    public Text m_scoreText;

    private int m_timeLeft;

    public void Start()
    {
        m_timeLeft = m_timeExperience;
    }

    public void StartPlay()
    {
        StartCoroutine(StartExperience());

        StartCoroutine(TimerLive());

        m_buttonStart.SetActive(false);
    }

    IEnumerator StartExperience()
    {
        ScoreManager.m_instance.m_score = 0;
        ScoreManager.m_instance.UpdateScore(0);
        yield return new WaitForSeconds(m_timeExperience);
        m_finalScore.SetActive(true);
        m_scoreText.text = ScoreManager.m_instance.m_score.ToString();
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
}
