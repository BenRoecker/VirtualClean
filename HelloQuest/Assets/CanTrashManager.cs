using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanTrashManager : MonoBehaviour
{
    public GameObject m_can2;
    public GameObject m_canSmall;
    public GameObject m_canTall2;
    public GameObject m_canTall;
    public GameObject m_can;
    public GameObject m_sodaCan;

    System.Random randomNumber = new System.Random();

    public void EnableTrashCanRandomly()
    {
        int num = randomNumber.Next(0, 6);

        Debug.Log(num);

        if (num == 0)
        {
            m_can2.SetActive(true);
        }
        else if (num == 1)
        {
            m_canSmall.SetActive(true);
        }
        else if (num == 2)
        {
            m_canTall2.SetActive(true);
        }
        else if (num == 3)
        {
            m_canTall.SetActive(true);
        }
        else if (num == 4)
        {
            m_can.SetActive(true);
        }
        else if (num == 5)
        {
            m_sodaCan.SetActive(true);
        }
    }
}
