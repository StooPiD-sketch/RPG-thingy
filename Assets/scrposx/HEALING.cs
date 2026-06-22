using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int health = 2;
    public helths playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth = collision.gameObject.GetComponent<helths>();
            playerHealth.healdamage(health);
        }
    }
}
