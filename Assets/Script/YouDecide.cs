using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouDecide : MonoBehaviour
{
    private float enemySpeed = 1;
    private GameObject Player;
    public enum Behavior {Spy, Warrior};
    public Behavior attitude;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        switch(attitude)
        {
            case Behavior.Spy:
                Debug.Log("modo espia");
                LookAtPlayer(Player);
                break;
            case Behavior.Warrior:
                Debug.Log("Modo Guerrero");
                Motion();
                break;
        }
    }

    void LookAtPlayer(GameObject lookobject)
    {
        Vector3 direction = lookobject.transform.position - transform.position;
        Quaternion newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = newQuaternion;
    }

    void Motion()
    {
        if(transform.position.x - 2 > Player.transform.position.x)
        {
            FollowPlayer();
        }
        if (transform.position.z - 2 > Player.transform.position.z)
        {
            FollowPlayer();
        }
        if (transform.position.y - 2 > Player.transform.position.y)
        {
            FollowPlayer();
        }
    }
    void FollowPlayer()
    {
        Vector3 direction = (Player.transform.position - transform.position).normalized;
        transform.position += enemySpeed * direction * Time.deltaTime;
    }
}
