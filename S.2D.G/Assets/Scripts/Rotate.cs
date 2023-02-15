using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] public float Speed = 2f;
    // Update is called once per frame
   public void Update()
    {
        transform.Rotate(0, 0, 360 * Speed * Time.deltaTime);
    }
}
