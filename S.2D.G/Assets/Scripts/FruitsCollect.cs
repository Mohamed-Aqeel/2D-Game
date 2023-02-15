using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsCollect : MonoBehaviour
{

    public Animator CollectAnim;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            CollectAnim.SetTrigger("Collected");
        }
    }
}
