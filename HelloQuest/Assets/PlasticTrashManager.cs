using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticTrashManager : MonoBehaviour
{
    public GameObject m_barrel1;
    public GameObject m_barrel2;

    System.Random randomNumber = new System.Random();

    public void EnableTrashPlasticRandomly()
    {
        int num = randomNumber.Next(0, 2);

        Debug.Log(num);

        if (num == 0)
        {
            m_barrel1.SetActive(true);
        }
        else if (num == 1)
        {
            m_barrel2.SetActive(true);
        }
    }
}
