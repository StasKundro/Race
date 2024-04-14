using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class RewAdd : MonoBehaviour
{
    public YandexGame sdk;
    public int coin;
    public TMP_Text textMoney;

    public void AddButton()
    {
        sdk._RewardedShow(1);
    }

    public void AddButtonCul()
    {
        coin = PlayerPrefs.GetInt("coin", coin);
        coin += 500;
        textMoney.text = coin.ToString();
        PlayerPrefs.SetInt("coin", coin);
    }
}
