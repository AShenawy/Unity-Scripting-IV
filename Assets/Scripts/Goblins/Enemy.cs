using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        // If the player presses E make the goblin shout
        if (Input.GetKeyDown(KeyCode.E))
        {
            Shout();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ThrowApple();
        }
    }

    void Shout()
    {
        EnemyDialogue dialogue = GetComponent<EnemyDialogue>();

        if (dialogue != null)
        {
            dialogue.Shout();
        }
        else
        {
            print("EnemyDialogue component not found!");
        }
    }

    void ThrowApple()
    {
        EnemyShooter shooter = GetComponent<EnemyShooter>();

        if (shooter != null)
        {
            shooter.Shoot();
        }
    }
}
