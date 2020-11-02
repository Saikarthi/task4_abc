using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    private Rigidbody rb;
    public float f= 5f;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(0, 0, -1f);
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce(pos * f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
