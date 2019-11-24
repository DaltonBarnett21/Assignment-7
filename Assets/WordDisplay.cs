using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//

public class WordDisplay : MonoBehaviour {

    public static int Score;
    public Text text;
	public float fallSpeed = 1f;

	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
        text.color = KeepData.ColorOfWord;
    }

	public void RemoveWord ()
	{
		Destroy(gameObject);
        Score++;
    }

	private void Update()
	{
        transform.Translate(0f, -fallSpeed * Time.deltaTime * KeepData.WordSpeedMultiplier, 0f);
    }

}
