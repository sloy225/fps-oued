using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    private CharacterController control;
    public float speed =5f;
    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        control.Move(move*speed*Time.deltaTime);
    }
}
