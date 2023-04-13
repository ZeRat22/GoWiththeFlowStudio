using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OvenStatus : MonoBehaviour
{
    private float ovenHealth = 50;
    private int ovenAttackers = 0;

   public Text ovenHealthMeter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ovenHealthMeter.text = "oven health : " + ovenHealth.ToString();   

        if (ovenAttackers > 0)
        {
            ovenHealth -= Time.deltaTime;
            Debug.Log("OVEN " + ovenHealth);
        }
        if (ovenHealth <= 0 )
        {
            SceneManager.LoadScene("TitleScene");
        }

    }
    void FixedUpdate()
    {

     //   Debug.Log("ATTACKERS " + ovenAttackers);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            ovenAttackers += 1;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            ovenAttackers -= 1;
        }
    }

}
 