using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int health = 500;
   

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 200)
        {
            GetComponent<Animator>().SetBool("Rage", true);
        }


        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<Animator>().SetBool("Dead", true);
        Destroy(gameObject);
    }
}
