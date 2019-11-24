using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
   
    public static float WordSpeedMultiplier = 1.0f;
    public static Color ColorOfWord = Color.white;

    
    public Dropdown wordColor;
    public Slider wordSpeed;
    public Text wordSpeedText;

    void Update()
    {
        wordSpeedText.text = WordSpeedMultiplier.ToString();
    }


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }

    public void SetWordSpeedMultiplier()
    {
        WordSpeedMultiplier = wordSpeed.value;
    }

    public void SetColorOfWord()
    {
        switch (wordColor.value)
        {
            case 1:
                ColorOfWord = Color.blue;
                break;
            case 2:
                ColorOfWord = Color.white;
                break;
            case 3:
                ColorOfWord = Color.red;
                break;
            case 4:
                ColorOfWord = Color.black;
                break;
            default:
                ColorOfWord = Color.gray;
                break;
        }
    }

}