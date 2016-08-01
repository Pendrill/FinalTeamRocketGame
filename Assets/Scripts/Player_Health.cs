using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {
    public int maxHealth = 100;
    public int currentHealth = 0;
    

    // Use this for initialization
    void Start()
    {
        // everyone starts at 100% health at the start
        currentHealth = maxHealth;

    }

    // notice we made this a public function; thats so death trigger can use it

    public void Hurt(int damage)
    {

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }
}
