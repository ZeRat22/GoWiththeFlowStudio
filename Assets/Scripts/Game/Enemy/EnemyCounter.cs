using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    GameObject[] enemies;
    public Text enemyCountText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     enemies = GameObject.FindGameObjectsWithTag("Enemy");
     enemyCountText.text = "Enemies : " + enemies.Length.ToString();   
    }
}
