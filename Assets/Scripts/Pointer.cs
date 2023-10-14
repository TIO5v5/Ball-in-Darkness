using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{

    public SpawnCoin coinManager;
    Transform PlayerTransform;
    public float rotationSpeed = 3f;

    private void Start()
    {
        PlayerTransform = FindObjectOfType<Player>().transform;
    }


    void Update()
    {
        transform.position = PlayerTransform.position;

        Coin clossestCoin = coinManager.GetClosest(transform.position);
        Vector3 targetPosition = clossestCoin.transform.position;
        Vector3 TargetPositionXZ = new Vector3(targetPosition.x, transform.position.y, targetPosition.z);
        Vector3 diraction = TargetPositionXZ - transform.position;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(diraction),Time.deltaTime * rotationSpeed);

    }
}
