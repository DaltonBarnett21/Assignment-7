using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSpeedSlider : MonoBehaviour
{
    public static float speed = 800;
    public Slider WordSlider;
    public Text WordSliderText;

    void Update()
    {
        WordSliderText.text = WordSlider.value.ToString();
        speed = WordSlider.value;
        PlayerPrefs.SetFloat("WordSpeed", speed);
    }
}
