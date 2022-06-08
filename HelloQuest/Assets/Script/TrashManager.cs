using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    public static TrashManager m_instance;

    [Header("Trash Can")]

    public GameObject m_trashCanGroup;

    [Header("Trash Plastic")]

    public GameObject m_trashPlasticGroup;

    [Header("Trash Paper")]

    public GameObject m_trashPaperGroup;

    [Header("Trash Glass")]

    public GameObject m_trashGlassGroup;

    public void Start()
    {
        if (m_instance == null)
        {
            m_instance = this;
        }
    }

    public void EnableTrashPrefab(int rndNum)
    {
        if(rndNum == 0)
        {
            Debug.Log("rndNum = 0");
            m_trashCanGroup.SetActive(true);
            m_trashCanGroup.GetComponent<CanTrashManager>().EnableTrashCanRandomly();
        }
        else if(rndNum == 1)
        {
            Debug.Log("rndNum = 1");
            m_trashGlassGroup.SetActive(true);
            m_trashGlassGroup.GetComponent<GlassTrashManager>().EnableTrashGlassRandomly();
        }
        else if(rndNum == 2)
        {
            Debug.Log("rndNum = 2");
            m_trashPaperGroup.SetActive(true);
            m_trashPaperGroup.GetComponent<PaperTrashManager>().EnableTrashPaperRandomly();
        }
        else if(rndNum == 3)
        {
            Debug.Log("rndNum = 3");
            m_trashPlasticGroup.SetActive(true);
            m_trashPlasticGroup.GetComponent<PlasticTrashManager>().EnableTrashPlasticRandomly();
        }
    }
}
