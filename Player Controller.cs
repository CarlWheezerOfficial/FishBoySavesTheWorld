using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject FP;
    public float speed;
    private Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        FP = GameObject.Find("Camera anchor");
    }

    // Update is called once per frame
    void Update()
    {
        float FI = Input.GetAxis("Vertical");
        RB.AddForce(FP.transform.forward * speed * FI);
        float HI = Input.GetAxis("Horizontal");
        RB.AddForce(FP.transform.right * speed * HI);
    }
}
