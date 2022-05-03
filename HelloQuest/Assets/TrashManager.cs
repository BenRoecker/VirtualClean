using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    public static TrashManager m_instance;

    public GameObject m_trash;

    public void Start()
    {
        if(m_instance == null)
        {
            m_instance = this;
        }

        //Creation of the trashes
        for (int i = 0; i < 1; i++) 
        {
            CreateTrash(i);
        }
    }

    public void CreateTrash(int pos)
    {
        GameObject m_newTrash = Instantiate(m_trash);
        m_newTrash.transform.position = new Vector3(pos + 3, 0, 0);
    }
}
