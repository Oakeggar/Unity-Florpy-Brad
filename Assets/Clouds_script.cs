using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds_script : MonoBehaviour
{
    public GameObject Cloud1;
    public GameObject Cloud2;
    private float moveSpeed;
    public float maxSpeed;
    public float minSpeed;
    public float deadZone;
    private int r_skin;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(minSpeed, maxSpeed);
        r_skin = Random.Range(1, 3);
        if (r_skin == 1)
        {
            Cloud1.SetActive(true);
        }
        else
        {
            Cloud2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
