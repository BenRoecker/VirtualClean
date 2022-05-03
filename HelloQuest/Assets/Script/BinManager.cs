using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinManager : MonoBehaviour
{
    public static BinManager m_instance;

    public GameObject m_destroyer;

    public ColorBin color = ColorBin.Blue;

    public enum ColorBin
    {
        Blue,
        Green,
        Yellow,
        Red
    }

    public void Start()
    {
        //Creation of the instance of the bin, if it doesn't exist already
        if(m_instance == null)
        {
            m_instance = this;
        }
    }
}
