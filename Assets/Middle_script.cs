using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle_script : MonoBehaviour
{
    public Logic_script logic;
    public int scoreToAdd;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(scoreToAdd);
        }
        
    }
}
