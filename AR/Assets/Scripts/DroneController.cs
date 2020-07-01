using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    Animator _Anim;
    // Start is called before the first frame update
    void Start()
    {
        _Anim = GetComponent<Animator>();
        _Anim.SetBool("walk", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
