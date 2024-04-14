using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    public float moveSpeed;

    private void Start()
    {
        moveSpeed = 20;
    }
    void FixedUpdate()
    {
        // Двигаем объект вперед по оси Z
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
