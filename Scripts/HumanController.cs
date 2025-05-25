using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class HumanController : MonoBehaviour
{
    private float speed;
    private float positionX;
    private float positionY;
    private Vector3 newPosition;
    private void Start()
    {
        speed = Random.Range(1, 4);
        positionX = Random.Range(-30f, -10f);
        positionY = Random.Range(0, 40);

    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * speed);

    }
}
