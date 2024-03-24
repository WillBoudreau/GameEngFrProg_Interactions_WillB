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
    public Dialogue dialogue;
    
    public Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        DialoguePanel.SetActive(false);
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
        nameText.text = dialogue.name;
        if(dialogue.name == null)
        {
            Debug.Log("name is null");
        }
        else if (nameText == null)
        {
            Debug.Log("name is full null");
        }
        Debug.Log(dialogueText.text + "1");
        Debug.Log(dialogue.name);
        Debug.Log(nameText);
    }
    public void EndDialogue()
    {
        sentences.Clear();
        DialoguePanel.SetActive(false);
    }
}
