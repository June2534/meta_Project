using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public int numBgCount = 5;
    
    public int obstacleCount = 0;
    public Vector3 obstaclePosition = Vector3.zero;
   
    void Start()
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();
        obstaclePosition = obstacles[0].transform.position;
        obstacleCount = obstacles.Length;

        for (int i = 0; i < obstacleCount; i++)
        {
            obstaclePosition = obstacles[i].SetRandomPlace(obstaclePosition, obstacleCount);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerd: " + collision.name);

        if (collision.CompareTag("BackGround"))
        {
            float widthOfBgObject = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject * numBgCount;

            collision.transform.position = pos;
            return;
        }
        
        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            obstaclePosition = obstacle.SetRandomPlace(obstaclePosition, obstacleCount);
        }
    }
}
