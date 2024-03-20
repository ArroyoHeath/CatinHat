using UnityEngine;
using UnityEngine.SceneManagement;

public class NetPickup : MonoBehaviour
{
    public string nextSceneName; //assign next scene in unity inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))  //player collides with game object (net)
        {
            SceneManager.LoadScene(nextSceneName);  //load the next scene
        }
    }
}

