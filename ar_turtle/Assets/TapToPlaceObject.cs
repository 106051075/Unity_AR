using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;
using UnityEngine.Animations;

[RequireComponent(typeof(ARReferencePoint))]
public class TapToPlaceObject : MonoBehaviour
{
    [Header("想放置的物件")]
    public GameObject tapObject;
    private ARRaycastManager arRaycast;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private Vector2 mousePos;
    private void Start()
    {
        arRaycast = GetComponent<ARRaycastManager>();
    }
    private void Update()
    {
        TapObgect();
    }
    private void TapObgect()
    {
        mousePos = Input.mousePosition;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Pose pose = hits[0].pose;
            GameObject temp = Instantiate(tapObject, pose.position, pose.rotation);
            Vector3 look = transform.position;
            look.y = temp.transform.position.y;
            temp.transform.LookAt(look);

        }
    }





}