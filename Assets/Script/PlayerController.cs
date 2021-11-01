using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;
    float cameraAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();

        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }

    }

    void MovePlayer(Vector3 direction)
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }

    void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X");
        Quaternion Angulo = Quaternion.Euler(0, cameraAxis, 0);
        transform.localRotation = Angulo;
    }
}
