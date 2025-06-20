using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSprawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heighOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
        
       
    }
    void SpawnPipe()
    {
        float lowesPoint = transform.position.y - heighOffset;
        float highesPoint = transform.position.y + heighOffset;

       Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowesPoint, highesPoint), 0), transform.rotation);

    }


}
