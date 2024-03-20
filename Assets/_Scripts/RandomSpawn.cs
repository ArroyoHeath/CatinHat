using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    Vector2 randomPosition;
    public float xRange = 3f;
    public float yRange = 3f;
    // Start is called before the first frame update
    void Start()
    {
        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = Random.Range(0-yRange, 0+ yRange);
        randomPosition = new Vector2(xPosition, yPosition);
        transform.position = randomPosition;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
