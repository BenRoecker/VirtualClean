using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassTrashManager : MonoBehaviour
{
    public GameObject m_bottle1;
    public GameObject m_bottle2;
    public GameObject m_bottle3;

    System.Random randomNumber = new System.Random();

    public void EnableTrashGlassRandomly()
    {
        int num = randomNumber.Next(0, 3);

        Debug.Log(num);

        if (num == 0)
        {
            m_bottle1.SetActive(true);
        }
        else if (num == 1)
        {
            m_bottle2.SetActive(true);
        }
        else if (num == 2)
        {
            m_bottle3.SetActive(true);
        }
    }
}
