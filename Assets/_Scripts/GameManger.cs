using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //singleton instance
    public int maxTouches = 3;    
    private int totalTouches = 0;   //counter to track number of times player has been touched
    public HealthUI healthUI;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        //initialize the health UI at the start of scene
        if (healthUI != null)
        {
            healthUI.SetHits(maxTouches);
        }
    }

    public void AddTouch()   //method that increases touch counter and ends the game if player is touched the max number of times; also maniuplates values for HealthUI 
    {
        totalTouches++;
        if (healthUI != null)
        {
            healthUI.SetHits(maxTouches - totalTouches);   
        }

        if (totalTouches >= maxTouches)
        {
            EndGame();
        }
    }

    private void EndGame()  //method that loads game over scene
    {
        SceneManager.LoadScene("GameOver"); //load the game over scene
    }
}
