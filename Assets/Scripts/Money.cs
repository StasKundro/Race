using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Money : MonoBehaviour
{
    public float moveSpeed;
    public int coin;
    public int carSelected;
    public GameObject[] carModel;

    private void Start()
    {
        carSelected = PlayerPrefs.GetInt("carSelected", carSelected);
        carModel[carSelected].SetActive(true);
        coin = PlayerPrefs.GetInt("coin", coin);
        StartCoroutine(plus1(1f));
    }
    IEnumerator plus1(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);
        coin += Mathf.RoundToInt(moveSpeed/10);
        PlayerPrefs.SetInt("coin", coin);
        StartCoroutine(plus2(1f));
    }
    IEnumerator plus2(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);
        coin += Mathf.RoundToInt(moveSpeed/10);
        PlayerPrefs.SetInt("coin", coin);
        StartCoroutine(plus1(1f));
    }

}
