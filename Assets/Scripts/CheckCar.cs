using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckCar : MonoBehaviour
{
    public int coin;
    public GameObject butPlay;
    public TMP_Text needText;
    public int needCoins;
    public void Update()
    {
        coin = PlayerPrefs.GetInt("coin", coin);

        if(coin >= needCoins)
        {
            butPlay.SetActive(true);
            needText.text = "";
        }
        else
        {
            butPlay.SetActive(false);
            needText.text = needCoins.ToString();
        }
    }
}
