using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTrashManager : MonoBehaviour
{
    public GameObject m_box1;
    public GameObject m_box2;
    public GameObject m_book1;
    public GameObject m_book2;

    System.Random randomNumber = new System.Random();

    public void EnableTrashPaperRandomly()
    {
        int num = randomNumber.Next(0, 4);

        Debug.Log(num);

        if (num == 0)
        {
            m_box1.SetActive(true);
        }
        else if (num == 1)
        {
            m_box2.SetActive(true);
        }
        else if (num == 2)
        {
            m_book1.SetActive(true);
        }
        else if (num == 3)
        {
            m_book2.SetActive(true);
        }
    }
}
