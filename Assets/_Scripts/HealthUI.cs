using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image[] hitShapes; //assign in the inspector
    private int hitsRemaining;

    public void SetHits(int hits) 
    {
        hitsRemaining = hits;  
        UpdateUI();
    }

    private void UpdateUI()  //method that removes heart image to visually represent how much health player has left
    {
        for (int i = 0; i < hitShapes.Length; i++)
        {
            hitShapes[i].enabled = i < hitsRemaining;  
        }
    }
}