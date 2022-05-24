using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAlpha : MonoBehaviour
{
    public Slider m_mainSlider;
    public GameObject m_currentGameObject;
    private Material m_currentMath;
    private float m_alpha;

    // Start is called before the first frame update
    void Start()
    {
        m_currentGameObject = gameObject;
        m_currentMath = m_currentGameObject.GetComponent<Renderer>().material;
        m_mainSlider.value = m_currentMath.color.a;
    }

    public void UpdateAlpha()
    {
        Color oldColor = m_currentMath.color;
        m_alpha = m_mainSlider.value;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, m_alpha);
        //Debug.Log(m_alpha + "  " + newColor.g + "   " + newColor.b + "     " + newColor.a);
        m_currentMath.SetColor("_Color", newColor);

    }

    /*public void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            Debug.Log("SHHHHHEEEEEEEEEEEEEEESSSSSSSSSSSSSHHHHHHHHHHHH");
            UpdateAlpha();
        }
    }*/
}
