using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour
{
    // Start is called before the first frame update

    //CCNY MW IN CLASS

    //GLOBAL VARIBLES

    public int SceneNumber;
    //0 = StartScene
    //1  = MainScene
    //3 = EndScene
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(SceneNumber == 0)
      {
        StartSceneControls(); 
      }
      else if (SceneNumber == 1) //in main scene
        {
            MainSceneControls();
        }
        else if(SceneNumber == 2)
        {
            EndSceneControls();
        }
        else if(SceneNumber == 3)
        {
            VictorySceneControls();
        }
       
    }
    public void StartSceneControls()
    {
      if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainScene");
        }   
    }    

    public void MainSceneControls()
    {
        Debug.Log("Main Scene Controls");
    }

    public void EndSceneControls()
    {
        Debug.Log("end scene Controls");
    }
    public void VictorySceneControls()
    {
        Debug.Log("Victory Scene controls");
    }

    public void MoveToScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
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
        }
    }
}

