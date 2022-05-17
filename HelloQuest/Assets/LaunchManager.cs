using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class LaunchManager : MonoBehaviour
{
    public GameObject m_trashParent;


    System.Random randomNumber = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < m_trashParent.transform.childCount; i++)
        {
            int num = randomNumber.Next(0, 4);
            Debug.Log(num);

            m_trashParent.transform.GetChild(i).GetComponent<TrashManager>().EnableTrashPrefab(num);
        }
    }
}
