using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{


    public Color red = Color.red;
    Renderer rend;
    Vector3 start;
    public GameObject gameObject;
    private Vector3 distance;


    void Start ()
	{
	    int a = 3;
        rend = GetComponent<Renderer>();
        Debug.Log(rend.material.color);
        start = this.transform.position;

	}

    void Update()
    {
        distance = this.transform.position - gameObject.transform.position;
        if(Input.GetKey(KeyCode.Space))
        {
            rend.material.color = Color.red;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rend.material.color = new Vector4(1, 1, 1, 1);
        }

        if (Input.GetKey(KeyCode.B))
        {
            this.transform.position = start;
        }
        rend.material.color = new Vector4(distance.x/10,distance.y/10,distance.z/10,1);
    }
	

}
