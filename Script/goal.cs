using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class goal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
          if(collision.gameObject.tag == "Player")
        {
             //Debug.Log("hit player");
            if(transform.position.y + 1 < collision.gameObject.transform.position.y)
            {
                SceneManager.LoadScene("VictoryScene");
                //PlayerControllerScript.TakeDamage(0);
            }
             if(transform.position.x < collision.gameObject.transform.position.x)
            {
                SceneManager.LoadScene("VictoryScene");
                //PlayerControllerScript.TakeDamage(0);
            }
             if(transform.position.x > collision.gameObject.transform.position.x)
            {
                SceneManager.LoadScene("VictoryScene");
                //PlayerControllerScript.TakeDamage(0);
            }

        }
    }
}
