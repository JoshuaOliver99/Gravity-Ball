using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    [SerializeField] GameObject menu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collided with " + collision.gameObject.name);

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Level Complete!");

            // To Do:
            // Play a sound
            // Make the goal animate

            // Display "level complete" panel
            menu.SetActive(true);
        }
    }

}