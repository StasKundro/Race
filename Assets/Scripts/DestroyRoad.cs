using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyRoad : MonoBehaviour
{
    void OnTriggerEnter(Collider other) //Для 3D - выполняется, когда Игрок войдет в зону триггера
    {
        if (other.gameObject.tag == "Road") //Проверяем тэг объекта
        {
            Destroy(other.gameObject);
        }
    }
}
