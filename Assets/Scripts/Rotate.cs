using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 45f; // �������� ��������

    void Update()
    {
        // ������� ������ ������ ����� ���
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
