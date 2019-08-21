using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {

    [SerializeField] float timeToWait = 2f;
    [SerializeField] float customTime = .4f;

    private void OnTriggerEnter2D(Collider2D collision) {
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel() {
        Time.timeScale = customTime;
        yield return new WaitForSecondsRealtime(timeToWait);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
