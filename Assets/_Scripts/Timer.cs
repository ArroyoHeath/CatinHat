using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60; //1 minute timer
    public Text timerText;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = $"Time: {timeRemaining:F2}";
        }
        else   //time's up and player loses
        {
            
            SceneManager.LoadScene("GameOver"); //load game over scene
        }
    }
}
