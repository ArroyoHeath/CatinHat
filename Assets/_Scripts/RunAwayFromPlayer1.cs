using UnityEngine;

public class RunAwayFromPlayer : MonoBehaviour
{
    public Transform player; 
    public float speed = 5.0f; //how fast things run away from players

    private void Update()  //update Things' positions
    {
        if (player != null)
        {
            Vector3 directionFromPlayer = transform.position - player.position;
            Vector3 moveDirection = directionFromPlayer.normalized;

            transform.position += moveDirection * speed * Time.deltaTime;
        }
    }
}

