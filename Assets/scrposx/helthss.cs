using UnityEngine;

public class helths : MonoBehaviour
{
    public int helth;
    public int maxhelth = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        helth = maxhelth;
    }

    public void takedamage(int amount)
    {
        helth -= amount;

        if (helth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void healdamage(int amount)
    {
        helth += amount;
        if(helth > maxhelth)
        {
            helth = maxhelth;
        }
    }
}