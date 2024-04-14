using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Road : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; // Массив префабов для спауна
    public float spawnInterval = 3f; // Интервал между спаунами
    public Transform target;
    public float baseSpeed=100;

    private float moveSpeed;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    void Start()
    {
        // Запускаем циклический спаун с заданным интервалом
        moveSpeed = 40;
        spawnInterval = baseSpeed / moveSpeed;
        StartCoroutine(spawn1(spawnInterval));
    }
    IEnumerator spawn1(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        GameObject randomPrefab = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)];
        Instantiate(randomPrefab, target.transform.position, target.transform.rotation);
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);
        spawnInterval = baseSpeed / moveSpeed;
        StartCoroutine(spawn2(spawnInterval));
    }
    IEnumerator spawn2(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        GameObject randomPrefab = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)];
        Instantiate(randomPrefab, target.transform.position, target.transform.rotation);
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);
        spawnInterval = baseSpeed / moveSpeed;
        StartCoroutine(spawn1(spawnInterval));
    }
}
