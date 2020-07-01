using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{
    Animator _Anim;
    Vector3 _Speed = new Vector3(0f, 0f, 0f);
    public float _SpeedMultiplayer = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        _Anim = GetComponent<Animator>();
        _Anim.SetBool("walk", true);
    }

    public void Move(float _speedX,float _speedY)
    {
        _Speed.x = _speedX;
        _Speed.y = _speedY;

        UpdateTurtle();
    }
    // Update is called once per frame
    void UpdateTurtle()
    {
        transform.localPosition += _Speed  * _SpeedMultiplayer * Time.deltaTime;
    }
}
