using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOv : MonoBehaviour
{
    void OnTriggerEnter(Collider other) //��� 3D - �����������, ����� ����� ������ � ���� ��������
    {
        if (other.gameObject.tag == "Enemy") //��������� ��� �������
        {
            SceneManager.LoadScene("GameOver"); //��������� �����
        }
    }
}
