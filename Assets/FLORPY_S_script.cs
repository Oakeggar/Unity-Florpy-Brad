using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FLORPY_S_script : MonoBehaviour
{
    public GameObject florpy;
    public Logic_script logic;
    public difficulty_options dif_options;
    public float spawnRate;
    public float heightOffset;
    public float difficultyTimer;
    private float timer = 0, timerD= 0;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_script>();
        spawnFLorp();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.gameOn) { 
        if (timerD < difficultyTimer)
        {
            timerD += Time.deltaTime;
        }
        else
        {
            timerD = 0;
            if(dif_options.starting_pa + dif_options.difficulty_s <= dif_options.difficulty) 
            {
                dif_options.starting_pa += dif_options.difficulty_s;
            }
            else if(dif_options.starting_pa + dif_options.difficulty_s > dif_options.difficulty)
            {
                dif_options.starting_pa = dif_options.difficulty;
            }
        }
        if (timer < spawnRate) 
        {
            timer += Time.deltaTime * dif_options.starting_pa;
        }
        else
        {
            spawnFLorp();
            timer = 0;
        }
        }
    }
    void spawnFLorp()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(florpy, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
