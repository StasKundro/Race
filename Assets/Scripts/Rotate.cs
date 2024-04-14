using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 45f; // Скорость вращения

    void Update()
    {
        // Вращаем объект вокруг своей оси
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
