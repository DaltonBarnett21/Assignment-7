using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayername;
    public Text WordSpeed;
   

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        showPlayername.text = PlayerName;
        WordSpeed.text = "Word Speed: " + PlayerPrefs.GetFloat("WordSpeed");
     

    }
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        showPlayername.text = PlayerName;
    }
    public void ShowNameFun()
    {
        showPlayername.text = PlayerName;
    }
}
