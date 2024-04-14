using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadNextScene()
    {

        SceneManager.LoadScene("GameScene");
    }

    public void startAnimation()
    {
        gameObject.GetComponent<Animator>().Play("skullIn");
    }
}
