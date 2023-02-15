using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] Waypoints;

    private int WPI = 0;
    [SerializeField] private float Speed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(Waypoints[WPI].transform.position,transform.position) < 0.1f)
        {
            WPI++;
            if (WPI >= Waypoints.Length)
            {
                WPI = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, Waypoints[WPI].transform.position, Time.deltaTime * Speed);
    }
}
