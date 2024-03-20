using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCapture : MonoBehaviour
{
    public int thingsCaught = 0;
    public Text captureCountText; //element in Unity Inspector

    private void Start()
    {
        UpdateCaptureCountUI();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            thingsCaught++;
            UpdateCaptureCountUI();
            Destroy(other.gameObject); //destroy the thing object once captured

            if (thingsCaught == 2) //catch 2 things to win
            {
                SceneManager.LoadScene("WinScene"); //load win scene
            }
        }
    }

    private void UpdateCaptureCountUI()    //method that updates the capture count
    {
        if (captureCountText != null)  //if value is not null
        {
            captureCountText.text = $"Captures: {thingsCaught}"; //display number of things caught
        }
    }
}

