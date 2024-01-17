using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour
{
    public static int levelCount =  10;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            int count = i + 1;
            if (count < levelCount)
            {
                transform.GetChild(i).GetComponent<Image>().color = new Color32(231, 202, 16, 255);
            }
            else if(count == levelCount)
            {
                transform.GetChild(i).GetComponent<Image>().color = new Color32(0, 210, 30, 255);
            }
            else
            {
                transform.GetChild(i).GetComponent<Image>().color = new Color32(115, 115, 115, 255);
            }
        }
    }
}
