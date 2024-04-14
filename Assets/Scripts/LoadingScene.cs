using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    AsyncOperation asyncOperation;
    public Image loadBar;

    private void Start()
    {
        StartCoroutine(loadSceneCor());
    }
    IEnumerator loadSceneCor()
    {
        yield return new WaitForSeconds(1f);
        asyncOperation = SceneManager.LoadSceneAsync("Game");
        while(!asyncOperation.isDone)
        {
            float progress = asyncOperation.progress / 0.9f;
            loadBar.fillAmount = progress;
            yield return 0;
        }
    }

}

