using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public GameObject interact = null;
    public InteractableOBJ Interactable = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interact == true)
        {
            Debug.Log("E pressed");
            if (Interactable.type == InteractableOBJ.Type.pickup)
            {
                Interactable.Pickup();
            }
            else if (Interactable.type == InteractableOBJ.Type.info)
            {
                Interactable.Info();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Interactable"))
        {
            interact = other.gameObject;
            Interactable = other.GetComponent<InteractableOBJ>();
        }
        else if(other.gameObject.CompareTag("Info"))
        {
            interact = other.gameObject;
            Interactable = other.GetComponent<InteractableOBJ>();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Interactable"))
        {
            interact = null;
            Interactable = null;
        }
    }
    void ExecuteInteractable()
    {

    }
}
