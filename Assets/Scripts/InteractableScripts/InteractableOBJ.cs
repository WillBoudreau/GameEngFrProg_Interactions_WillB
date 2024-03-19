using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InteractableOBJ : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI NavMessageText;
    [SerializeField] public string NavMessage;

    public float Delay = 5f;
    public enum Type
    {
        nothing,
        pickup,
        dialogue,
        info
    }
    public Type type;
    // Start is called before the first frame update
    void Start()
    {
        NavMessageText.text = null;
    }
    void Nothing()
    {

    }
    public void Pickup()
    {
        Debug.Log("You picked up..." + gameObject.name);
        this.gameObject.SetActive(false);
        if(gameObject.name == "Coin")
        {
            Debug.Log("Hello!");
        }
    }
    void Dialogue()
    {

    }
    public void Info()
    {
        Debug.Log(NavMessage);
        StartCoroutine(InfoDisplay(5f,NavMessage));
    }
    IEnumerator InfoDisplay(float Delay, string messageText)
    {
        NavMessageText.text = NavMessage;
        yield return new WaitForSeconds(Delay);
        NavMessageText.text = null;
    }
}
