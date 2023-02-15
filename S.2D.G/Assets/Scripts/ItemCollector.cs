using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    
    private int Kiwi = 0;
   [SerializeField] private Text KiwiText;
    [SerializeField] private AudioSource CollectKiwi;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            CollectKiwi.Play();
            Destroy(collision.gameObject);
            Kiwi++;
            KiwiText.text = "Fruits Collected :" + Kiwi;
          
        }
    
    }
}
