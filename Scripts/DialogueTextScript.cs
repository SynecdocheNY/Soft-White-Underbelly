using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTextScript : MonoBehaviour
{
    public string scriptText;
    public bool finishedScrolling = false;

    Text selfText;
    int dialogueProgress = 0;

    // Start is called before the first frame update
    void Start()
    {
        selfText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // Advance 1 char per frame
        if (selfText.text.Length == scriptText.Length - 1)
        {
            selfText.text = scriptText;
            finishedScrolling = true;
        }
        else if (finishedScrolling == false)
        {
            selfText.text = scriptText.Remove(1 + dialogueProgress);
            dialogueProgress += 1;
        }
    }

    // To be called by NPCs
    public void InjectText(string textToInject)
    {
        scriptText = textToInject;
        finishedScrolling = false;
    }
}
