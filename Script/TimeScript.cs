using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeScript : MonoBehaviour
{
    public float Timer = 22;
    public TextMeshProUGUI TimeTxt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeTxt.text = "Timer: " + Mathf.Round(Timer);
        {
	    Timer -= Time.deltaTime;
	 if (Timer <= 0)
	    {
		    SceneManager.LoadScene("EndScene");
	    }
      }
    }  
}
