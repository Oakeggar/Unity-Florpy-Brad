using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLORPY_script : MonoBehaviour
{
    public GameObject Middle;
    public float moveSpeed;
    public float deadZone;
    public FLORPY_S_script difficulty;
    public Logic_script restart;
    //public BRAD_script brad;
    // Start is called before the first frame update
    void Start()
    {
        difficulty = GameObject.FindGameObjectWithTag("spawner").GetComponent<FLORPY_S_script>();
        restart = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_script>();
        //brad = GameObject.FindGameObjectWithTag("brad").GetComponent<BRAD_script>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime * difficulty.dif_options.starting_pa;
        if((transform.position.x < deadZone | restart.restart == true) ^ restart.gameOn == false)
        {
            Destroy(gameObject);
        }
        /*
        if(brad.alive == false)
        {
            Middle.SetActive(false);
        }
        */
    }
}
