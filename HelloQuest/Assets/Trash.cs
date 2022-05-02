using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public GameObject m_trash;

    public static Trash m_instance;

    public Rigidbody m_trashRigidbody;

    public trash garbage = trash.can;

    public enum trash
    {
        plastic,
        glass,
        can,
        paper
    }

    public void Start()
    {
        if(m_instance == null)
        {
            m_instance = this;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bin")
        {
            Debug.Log("tag detected + " + garbage.ToString());
            if(garbage == trash.can && BinManager.m_instance.color == BinManager.ColorBin.Red)
            {
                Debug.Log("It's a can");
                ScoreManager.m_instance.UpdateScore(5);
            }
            else if (garbage == trash.glass && BinManager.m_instance.color == BinManager.ColorBin.Blue)
            {
                Debug.Log("It's a glass");
                ScoreManager.m_instance.UpdateScore(5);
            }
            else if (garbage == trash.paper && BinManager.m_instance.color == BinManager.ColorBin.Green)
            {
                Debug.Log("It's a paper");
                ScoreManager.m_instance.UpdateScore(5);
            }
            else if (garbage == trash.plastic && BinManager.m_instance.color == BinManager.ColorBin.Yellow)
            {
                Debug.Log("It's a plastic"); 
                ScoreManager.m_instance.UpdateScore(5);
            }
            else
            {
                ScoreManager.m_instance.UpdateScore(-10);
            }
            TrashManager.m_instance.DestroyTrash();
        }
    }
}
