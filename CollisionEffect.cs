using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEffect : MonoBehaviour
{
       void OnCollisionEnter(Collision collision)
    {
        // Check if the collision was with a game object with the "Enemy" tag
        if (collision.gameObject.tag == "Lose")
        {
            // Do something when the object collides with an enemy
            Debug.Log("Collision with enemy detected!");
        }
    }
}
