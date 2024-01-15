using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JUTPS.ItemSystem;

public class TranslateForGuns : MonoBehaviour
{
    [SerializeField] private Item DesertEgle;
    [SerializeField] private Item Knife;
    [SerializeField] private Item Machete;
    [SerializeField] private Item Benelli;

    // Start is called before the first frame update
    void Start()
    {
        if (Translator.LangageId == 1) {
            DesertEgle.ItemName = "Пустынный орел";
            Knife.ItemName = "Нож";
            Machete.ItemName = "Мачете";
            Benelli.ItemName = "Дробовик";
        }
    }
}
