using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float defaultFOV = 60f; // Начальный угол обзора камеры
    public float zoomedFOV = 30f; // Угол обзора при увеличении
    public float unZoomedFOV = 30f;
    public float zoomSpeed = 5f; // Скорость увеличения/уменьшения угла обзора
    public float unZoomSpeed = 5f; // Скорость увеличения/уменьшения угла обзора

    private void Update()
    {
        // Обработка увеличения/уменьшения угла обзора при нажатии клавиши W
        if (Input.GetKey(KeyCode.W))
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoomedFOV, Time.deltaTime * zoomSpeed);
        }
        else
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, defaultFOV, Time.deltaTime * zoomSpeed);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Space))
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, unZoomedFOV, Time.deltaTime * unZoomSpeed);
        }
        else
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, defaultFOV, Time.deltaTime * unZoomSpeed);
        }
    }
}
