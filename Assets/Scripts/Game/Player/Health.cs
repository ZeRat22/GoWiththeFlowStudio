using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int amount) {

        currentHealth -= amount;

        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0) {

            //Destroy(gameObject);
            SceneManager.LoadScene("TitleScene");

        }
    }


    // Update is called once per frame
   
}
