using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float defaultFOV = 60f; // ��������� ���� ������ ������
    public float zoomedFOV = 30f; // ���� ������ ��� ����������
    public float unZoomedFOV = 30f;
    public float zoomSpeed = 5f; // �������� ����������/���������� ���� ������
    public float unZoomSpeed = 5f; // �������� ����������/���������� ���� ������

    private void Update()
    {
        // ��������� ����������/���������� ���� ������ ��� ������� ������� W
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
