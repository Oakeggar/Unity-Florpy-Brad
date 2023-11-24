using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starting_options : MonoBehaviour
{
    public Slider slider;
    public float starting_pa;
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) => { starting_pa = v; });
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
