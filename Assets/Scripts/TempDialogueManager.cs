using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempDialogueManager : MonoBehaviour
{
    public string[] dialogue;
    public Text text;

    private int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = dialogue[0];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UpdateDialogue();
        }
    }

    void UpdateDialogue()
    {
        if (cnt < dialogue.Length - 1)
        {
            cnt++;
            text.text = dialogue[cnt];
        }
        else
        {
            Application.Quit();
        }
    }
}
