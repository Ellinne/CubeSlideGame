using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Toggle tg1;
    public Toggle tg2;
    public Toggle tg3;


    public void SetVolume(float v)
    {
        audioMixer.SetFloat("volume", v);
    }
    public void SetQuality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }

	public void SetFontSize()
    {
        if (tg1.isOn)
            PlayerPrefs.SetInt("FontSize", 20);
        if (tg2.isOn)
            PlayerPrefs.SetInt("FontSize", 40);
        if (tg3.isOn)
            PlayerPrefs.SetInt("FontSize", 60);
    }
    public void NewFont()
    {

    }
}
