using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Translator : MonoBehaviour
{
    public static int LangageId;
    
    private static List<Translatable_text> listId = new List<Translatable_text>();

    #region ВЕСЬ ТЕКСТ

    private static string[,] LineText =
    {
        #region АНГЛИЙСКИЙ
        {
            "Start Game",//0
            "Rate",//1
            "How to play",//2
            "UP",//3
            "LEFT",//4
            "RIGHT",//5
            "DAWN",//6
            "RELOAD",//7
            "JUMP",//8
            "ROLL",//9
            "FIRE",//10
            "FIRE MODE",//11
            "Machete",//12
            "Infinite\r\nAmmo",//13
            "Desert Egle",//14
            "RECEIVED!",//15
            "For one round\r\nper ADS",//16
            "Settings",//17
            "Music",//18
            "Sound Effects",//19
            "Thank you for playing our game! \r\nSee you soon!",//20
            "Dear friend!", //21
            "SIT DOWN",//22
            "RUN", //23
            "BOSS"//24

        },
        #endregion
        #region РУССКИЙ
        {
            "Начать игру",
            "Оценить",
            "Как играть",
            "ВВЕРХ",
            "ВЛЕВО",
            "ВПРАВО",
            "ВНИЗ",
            "ПЕРЕЗАРЯДКА",
            "ПРЫЖОК",
            "ПЕРЕКАТ",
            "ОГОНЬ",
            "ПРИЦЕЛ",
            "Мачете",
            "Бесконечный\r\nмагазин",
            "Пустынный орел",
            "ПОЛУЧЕНО!",
            "На один раунд\r\nЗа рекламу",
            "Настройки",
            "Музыка",
            "Звуки",
            "Спасибо что прошел нашу игру! \r\nПродолжение выйдет совсем скоро!",
            "Дорогой друг!",  
            "СЕСТЬ", 
            "БЕГ", 
            "БОСС"
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