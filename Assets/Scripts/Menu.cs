using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject[] carModel;
    public int carSelected;
    public int coin;
    public TMP_Text coinText;

    private void Start()
    {
        carSelected = PlayerPrefs.GetInt("carSelected", carSelected);
        coin = PlayerPrefs.GetInt("coin", coin);
        coinText.text = coin.ToString();

        carModel[carSelected].SetActive(true);
    }
    public void FixedUpdate()
    {
        if (carSelected == 0)
        {
            for (int i = 0; i < carModel.Length; i++)
            {
                carModel[i].SetActive(false);
            }
            carModel[carSelected].SetActive(true);
        }
        if (carSelected == 1)
        {
            for (int i = 0; i < carModel.Length; i++)
            {
                carModel[i].SetActive(false);
            }
            carModel[carSelected].SetActive(true);
        }
        if (carSelected == 2)
        {
            for (int i = 0; i < carModel.Length; i++)
            {
                carModel[i].SetActive(false);
            }
            carModel[carSelected].SetActive(true);
        }
        if (carSelected == 3)
        {
            for (int i = 0; i < carModel.Length; i++)
            {
                carModel[i].SetActive(false);
            }
            carModel[carSelected].SetActive(true);
        }
        if (carSelected == 4)
        {
            for (int i = 0; i < carModel.Length; i++)
            {
                carModel[i].SetActive(false);
            }
            carModel[carSelected].SetActive(true);
        }
    }

    public void GoPlay()
    {
        SceneManager.LoadScene("Loading");
    }

    public void GoNext()
    {
        if (carSelected < 4)
        {
            carSelected++;
        }
        else
        {
            carSelected = 0;
        }
        PlayerPrefs.SetInt("carSelected", carSelected);
    }
    public void GoPrev()
    {
        if (carSelected > 0)
        {
            carSelected--;
        }
        else
        {
            carSelected = 4;
        }
        PlayerPrefs.SetInt("carSelected", carSelected);
    }
}
