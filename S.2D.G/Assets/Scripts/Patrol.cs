using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private float waittime;
    public float startWaitTime;

    public Transform[] MoveSpots;

    private int randomspots;




    void Start()
    {
        waittime = startWaitTime;
        randomspots = Random.Range(0, MoveSpots.Length);
    }
   

    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, MoveSpots[randomspots].position, speed* Time.deltaTime);

        if (Vector2.Distance(transform.position, MoveSpots[randomspots].position) < 0.2f)
        {
            if (waittime <=0)
            {
                randomspots = Random.Range(0, MoveSpots.Length);
                waittime = startWaitTime;
            }
            else
            {
                waittime = Time.deltaTime;
            }
        }
    }
}
