using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject questdialogUI;
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null) {  
            Destroy(gameObject);
        }
            instance = this; 
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Questdialog()
    {
        questdialogUI.SetActive(true);
    }

    public void Questdialogoff()
    {
        questdialogUI.SetActive(false);
    }
}
