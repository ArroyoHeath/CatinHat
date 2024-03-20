using UnityEngine;

public class EnemyCollision_2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")  //game object (NPC) collides with player
        {
            GameManager.instance.AddTouch();   //increase number of times player was touched
        }
    }
}