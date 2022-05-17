using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public string m_nameScene;

    public void StartButton()
    {
        SceneManager.LoadScene(m_nameScene);
    }
}
