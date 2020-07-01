using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{
    Animator _Anim;
    Vector3 _speed = new Vector3(0.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        _Anim = GetComponent<Animator>();
        _Anim.SetBool("walk", true);
    }

    public void Move(float _speedX, float _speedY)
    {
        _speed.x = _speedX;
        _speed.y = _speedY;
    }

    // Update is called once per frame
    void UpdateTurtle()
    {
        transform.localPosition += _speed * Time.deltaTime;
    }
}
