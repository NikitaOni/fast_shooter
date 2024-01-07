using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_menu : MonoBehaviour
{
    public Text test_text;

    private void Start()
    {
        if(PlayerPrefs.HasKey("Language") == false)
        {
            PlayerPrefs.SetInt("Langague", 1);
        }
        Translator.Select_language(PlayerPrefs.GetInt("Langague"));
    }

    public void Language_change(int languageID)
    {
        PlayerPrefs.SetInt("Langague", languageID);
        Translator.Select_language(PlayerPrefs.GetInt("Langague"));
    }

    public void Show_text()
    {
        test_text.enabled = true;
        Debug.Log(Translator.Get_text(1));
        test_text.text = Translator.Get_text(1);
    }
}
