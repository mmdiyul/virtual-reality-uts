using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public void GoTo(string page) {
        SceneManager.LoadScene(page);
    }

    public void Exit() {
        Application.Quit();
    }
}
