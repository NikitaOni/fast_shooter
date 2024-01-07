using UnityEngine;
using UnityEngine.UI;

public class Translatable_text : MonoBehaviour
{
    public int textID;

    [HideInInspector] public Text UIText;

    private void Awake()
    {
        UIText = GetComponent<Text>();

        Translator.Add(this);
    }

    private void OnEnable()
    {
        Translator.Update_texts();
    }

    private void OnDestroy()
    {
        Translator.Delete(this);
    }
}
