using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BusSpawn : MonoBehaviour
{
    public GameObject leftBus;
    public GameObject rightBus;
    public float spawnInterval = 3f; // »нтервал между спаунами
    public Transform targetLeft;
    public Transform targetRight;
    public float baseSpeed = 100;

    private float moveSpeed;

    void Start()
    {
        // «апускаем циклический спаун с заданным интервалом
        moveSpeed = 40;
        spawnInterval = baseSpeed / moveSpeed;
        StartCoroutine(spawn1(spawnInterval));
    }
    IEnumerator spawn1(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        int x = Random.Range(1, 3);
        if (x == 1)
        {
            Instantiate(leftBus, targetLeft.transform.position, targetLeft.transform.rotation);
        }
        else
        {
            Instantiate(rightBus, targetRight.transform.position, targetRight.transform.rotation);
        }
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);
        spawnInterval = baseSpeed / moveSpeed;
        StartCoroutine(spawn2(spawnInterval));
    }
    IEnumerator spawn2(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        int x = Random.Range(1, 3);
        if (x == 1)
        {
            Instantiate(leftBus, targetLeft.transform.position, targetLeft.transform.rotation);
        }
        else
        {
            Instantiate(rightBus, targetRight.transform.position, targetRight.transform.rotation);
        }
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);
        spawnInterval = baseSpeed / moveSpeed;
        StartCoroutine(spawn1(spawnInterval));
    }
}
