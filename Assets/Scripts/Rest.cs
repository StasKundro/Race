using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startGame(2));
    }

    IEnumerator startGame(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        SceneManager.LoadScene("Main");
    }
}
