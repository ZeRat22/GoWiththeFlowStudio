using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("YES");
        SceneManager.LoadScene("Game");
    }
}