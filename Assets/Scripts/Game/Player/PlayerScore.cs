using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{

    [SerializeField]
    private int _scoreToWin;
    public static int _currentScore;
    // Start is called before the first frame update
    void Start()
    {
        _currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
