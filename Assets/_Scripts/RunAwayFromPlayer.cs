using UnityEngine;

public class RunAwayFromPlayer : MonoBehaviour
{
    public Transform player; 
    public float speed = 5.0f; //how fast things run away from players
    public float checkDistance = 1.0f;

    private void Update()  //update Things' positions
    {
        if (player != null)
        {
            Vector3 directionFromPlayer = transform.position - player.position;
            Vector3 moveDirection = directionFromPlayer.normalized;

            RaycastHit2D hit = Physics2D.Raycast(transform.position, moveDirection, checkDistance);   //use raycasting to dectect obstacles in the move direction
            if(hit.collider != null)   //case where an obstacle is in the way
            {
                moveDirection = Vector2.Perpendicular(moveDirection).normalized;   //move the npc perpendicular if there is something in their way

                RaycastHit2D leftHit = Physics2D.Raycast(transform.position, Vector2.Perpendicular(moveDirection), checkDistance);
                RaycastHit2D rightHit = Physics2D.Raycast(transform.position, Vector2.Perpendicular(moveDirection) * -1, checkDistance);

                if(leftHit.collider == null && rightHit.collider != null)
                {
                    moveDirection = Vector2.Perpendicular(moveDirection);
                }

                else if(rightHit.collider == null && leftHit.collider != null)
                {
                    moveDirection = Vector2.Perpendicular(moveDirection) * -1;
                }
            }

            transform.position += moveDirection * speed * Time.deltaTime;
        }
    }
}

