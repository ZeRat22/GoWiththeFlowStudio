using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Game");
    }
}