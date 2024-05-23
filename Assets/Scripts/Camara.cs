using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float speedRotate;
    float rotacionX;

    public Transform player;
    void Start()
    {

    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * speedRotate * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * speedRotate * Time.deltaTime;

        rotacionX -= mouseY;
        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacionX, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
