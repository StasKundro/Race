using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOv : MonoBehaviour
{
    void OnTriggerEnter(Collider other) //Для 3D - выполняется, когда Игрок войдет в зону триггера
    {
        if (other.gameObject.tag == "Enemy") //Проверяем тэг объекта
        {
            SceneManager.LoadScene("GameOver"); //Загружаем сцену
        }
    }
}
