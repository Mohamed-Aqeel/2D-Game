using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHit : MonoBehaviour
{
    public Animator ArrowGone;
    public GameObject Arrow;

    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("Kiwi"))
        {
            Destroy(collision.gameObject);
            Die();
          
        }
    }

    private void Die()
    {
        ArrowGone.SetTrigger("Gone");
    }
}
