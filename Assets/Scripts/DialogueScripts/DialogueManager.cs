using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject DialoguePanel;
    
    public Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(string[] dialogueSentence)
    {
        sentences.Clear();
        Debug.Log("Started Dialogue");
        DialoguePanel.SetActive(true);
        foreach(string sentence in dialogueSentence)
        {
            Debug.Log(sentence);
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(dialogueText.text + "1");
    }
    public void EndDialogue()
    {
        sentences.Clear();
        DialoguePanel.SetActive(false);
    }
}
