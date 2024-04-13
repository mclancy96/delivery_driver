using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 300f;
    [SerializeField] float translateSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotateAmount = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float translateAmount = Input.GetAxis("Vertical") * translateSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotateAmount);
        transform.Translate(0.0f, translateAmount, 0.0f);
    }
}
