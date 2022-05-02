using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager m_instance;

    public Text m_scoreText;

    public int m_score;

    public void Start()
    {
        if(m_instance == null)
        {
            m_instance = this;
        }
    }

    public void UpdateScore(int add)
    {
        m_score = m_score + add;

        m_scoreText.text = m_score.ToString() + "pts";
    }
}
