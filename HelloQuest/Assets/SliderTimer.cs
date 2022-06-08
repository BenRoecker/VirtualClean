using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTimer : MonoBehaviour
{
    public Slider m_mainSlider;

    public void SliderNewTimer()
    {
        if(m_mainSlider.value == 0)
        {
            PlayerPrefs.SetInt("Timer", 30);
        }
        else if (m_mainSlider.value == 1)
        {
            PlayerPrefs.SetInt("Timer", 60);
        }
        else if (m_mainSlider.value == 2)
        {
            PlayerPrefs.SetInt("Timer", 90);
        }

    }
}
