using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private GameObject Player;
    private float enemySpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {  
        if (transform.position.x - 2 > Player.transform.position.x)
        {
            MoveTowards();
        }
        if (transform.position.z - 2 > Player.transform.position.z)
        {
            MoveTowards();
        }
        if (transform.position.y- 2 > Player.transform.position.y)
        {
            MoveTowards();
        }

    }

    private void MoveTowards()
    {
        Vector3 direction = (Player.transform.position - transform.position).normalized;
        transform.position += enemySpeed * direction * Time.deltaTime;
    }
}
