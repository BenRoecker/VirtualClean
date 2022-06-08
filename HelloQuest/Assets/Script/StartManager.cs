using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public string m_nameScene;

    public static StartManager m_instance;

    public void Start()
    {
        if(m_instance == null)
        {
            m_instance = this;
        }
    }

    public void StartButton()
    {
        Debug.Log(m_nameScene);
        SceneManager.LoadScene(m_nameScene);
    }
}
