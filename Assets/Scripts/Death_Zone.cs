using UnityEngine;
using System.Collections;

public class Death_Zone : MonoBehaviour {
    public int damage = 1;
    // a funtion that is automatically called when
    //something with a Rigidbody2D enters

    void OnTriggerEnter2D(Collider2D activator)
    {
        // does the activating thing have a killable script on it?
        if (activator.GetComponent<Player_Health>() != null)
        {
            // TODO: substract health from the killable script

            // destroy this object
            //Destroy(activator.gameObject);

        }
    }
    void OnTriggerStay2D(Collider2D activator)
    {
        // does the activating thing have a killable script on it?
        if (activator.GetComponent<Player_Health>() != null)
        {
            activator.GetComponent<Player_Health>().Hurt(damage);

        }
    }
}
