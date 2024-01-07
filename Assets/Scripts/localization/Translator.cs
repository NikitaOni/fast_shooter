using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Translator : MonoBehaviour
{
    private static int LangageId;
    
    private static List<Translatable_text> listId = new List<Translatable_text>();

    #region ÂÅÑÜ ÒÅÊÑÒ

    private static string[,] LineText =
    {
        #region ÀÍÃËÈÉÑÊÈÉ
        {
            "Start Game",//0
            "Shop",//1
            "How to play",//2
            "UP",//3
            "LEFT",//4
            "RIGHT",//5
            "DAWN",//6
            "RELOAD",//7
            "JUMP",//8
            "ROLL",//9
            "FIRE",//10
            "FIRE MODE"//11
        },
        #endregion
        #region ĞÓÑÑÊÈÉ
        {
            "Íà÷àòü èãğó",
            "Ìàãàçèí",
            "Êàê èãğàòü",
            "ÂÂÅĞÕ",
            "ÂËÅÂÎ",
            "ÂÏĞÀÂÎ",
            "ÂÍÈÇ",
            "ÏÅĞÅÇÀĞßÄÊÀ",
            "ÏĞÛÆÎÊ",
            "ÏÅĞÅÊÀÒ",
            "ÎÃÎÍÜ",
            "ÏĞÈÖÅË"
        },
        #endregion
    };
    #endregion

    static public void Select_language(int id)
    {
        LangageId = id;
        Update_texts();
    }

    static public string Get_text(int textKey)
    {
        return LineText[LangageId, textKey];
    }

    static public void Add(Translatable_text idtext)
    {
        listId.Add(idtext);
    }

    static public void Delete(Translatable_text idtext)
    {
        listId.Remove(idtext);
    }

    static public void Update_texts()
    {
        for (int i = 0; i < listId.Count; i++)
        {
            listId[i].UIText.text = LineText[LangageId, listId[i].textID];
        }
    }

}