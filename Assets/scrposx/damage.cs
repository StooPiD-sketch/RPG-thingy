using UnityEngine;

public class damage : MonoBehaviour
{
    public int damaged = 2;
    public helths playerHealth;
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
            playerHealth.takedamage(damaged);
        }
    }
}
