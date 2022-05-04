using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    public static TrashManager m_instance;

    [Header("Trash Can")]

    public GameObject m_trashCan2;
    public GameObject m_trashCanSmall;
    public GameObject m_trashCanTall2;
    public GameObject m_trashCanTall;
    public GameObject m_trashCan;
    public GameObject m_trashSodaCan;

    public void Start()
    {
        if(m_instance == null)
        {
            m_instance = this;
        }

        //Creation of the trashes
        for (int i = 0; i < 1; i++) 
        {
            CreateTrash(i, m_trashCan2);
        }
    }

    public void CreateTrash(int pos, GameObject trash)
    {
        GameObject m_newTrash = Instantiate(trash);
        m_newTrash.transform.position = new Vector3(pos + 3, 0, 0);
    }
}
