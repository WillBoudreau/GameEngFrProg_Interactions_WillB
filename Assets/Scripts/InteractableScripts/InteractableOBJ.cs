using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractableOBJ : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI NavMessageText;
    [SerializeField] public string NavMessage;
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
        NavMessageText.text = NavMessage;
    }
}
