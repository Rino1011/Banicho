using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timescript : MonoBehaviour
{
    public float gameTimeInSeconds = 86400f; // 24 hours in seconds = 86400f  48 hours in seconds = 172800f  72 hours in seconds = 259200f

    void Start()
    {
        StartCoroutine(CountdownToGameOver());
    }

    IEnumerator CountdownToGameOver()
    {
        yield return new WaitForSeconds(gameTimeInSeconds);
        SceneManager.LoadScene("GameOver");
    }
}