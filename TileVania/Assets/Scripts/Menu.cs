using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    [SerializeField] int firstLevelIndex = 1;

    public void StartFirstLevel() {
        SceneManager.LoadScene(1);
    }

    public void Replay() {
        SceneManager.LoadScene(0);
    }

}
