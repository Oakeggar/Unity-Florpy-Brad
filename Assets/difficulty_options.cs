using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difficulty_options : MonoBehaviour
{
    public Slider slider;
    public Logic_script logic;
    public float difficulty;
    public float difficulty_s;
    public float starting_pa;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_script>();
        slider.onValueChanged.AddListener((v) => 
        {
            difficulty = v * 2; 
            difficulty_s = (v / 5); 
            starting_pa = difficulty_s + logic.dif_options_s; 
            /*
            switch (v)
            {
                case 1:
                    difficulty = 2;
                    difficulty_s = 1;
                    starting_pa = 1;
                    break;
                case 2:
                    difficulty = 4;
                    difficulty_s = 1;
                    starting_pa = 1;
                    break;
                case 3:
                    difficulty = 6;
                    difficulty_s = 1;
                    starting_pa = 1;
                    break;
            }
            */
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
