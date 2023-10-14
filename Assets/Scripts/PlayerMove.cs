using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody _rigidbody;
    public Transform CameraCenter;
    public float TorqueValue;
    public float MAV = 7;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        _rigidbody.AddTorque(CameraCenter.right * Input.GetAxis("Vertical") * TorqueValue);
        _rigidbody.AddTorque(-CameraCenter.forward * Input.GetAxis("Horizontal") * TorqueValue);
        _rigidbody.maxAngularVelocity = MAV;
        if(!GameManager.instance.isLose && transform.position.y < -1)
        {
            GameManager.instance.Lose();
        }
        if (GameManager.instance.isLose)
        {
            if(transform.position.y < -15f)
            {
                transform.position = new Vector3(0f, 25, 0f);
            }
            else if(transform.position.y > 0f && transform.position.y < 10f)
            {
                GameManager.instance.RestartGame();
            }
        }
    }
}
