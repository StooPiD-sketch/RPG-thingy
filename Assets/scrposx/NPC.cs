using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPC : MonoBehaviour
{
    bool player_detection = false;
   
    // Update is called once per frame
    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && player_detection)
        {
            print("E");
            GameManager.instance.Questdialog();
            GameManager.instance.Questdialogoff();
        }
        else if (context.performed)
        {
            GameManager.instance.Questdialogoff();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            player_detection = true;
            print("player detected");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }
}

