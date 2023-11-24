using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds_s_script : MonoBehaviour
{
    public GameObject Clouds;
    public float spawnRate;
    public float heightOffset;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

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
            spawnClouds();
            timer = 0;
        }
    }
    void spawnClouds()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Clouds, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
