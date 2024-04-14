using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyRoad : MonoBehaviour
{
    void OnTriggerEnter(Collider other) //��� 3D - �����������, ����� ����� ������ � ���� ��������
    {
        if (other.gameObject.tag == "Road") //��������� ��� �������
        {
            Destroy(other.gameObject);
        }
    }
}
