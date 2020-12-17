using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotarCamara : MonoBehaviour
{
    /*
    public GameObject target;
    float speed = 5;

    float minFov = 35f;
    float maxFov = 100f;
    float sensitivity = 17f;

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.RotateAround(target.transform.position, transform.up, Input.GetAxis("Mouse X") * speed);
            transform.RotateAround(target.transform.position, transform.right, Input.GetAxis("Mouse Y") * speed);
        }
    }

    */
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] private float distanceToTarget = 10;

    private Vector3 previousPosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(1))
        {
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;

            float rotationAroundYAxis = -direction.x * 180; // camera moves horizontally
            float rotationAroundXAxis = direction.y * 180; // camera moves vertically

            cam.transform.position = target.position;

            cam.transform.Rotate(new Vector3(1, 0, 0), rotationAroundXAxis);
           cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World);

            cam.transform.Translate(new Vector3(0, 0, -distanceToTarget));

            previousPosition = newPosition;
        }
    } 
    /*
    public Camera  camera;
    void Update()
    {
        //this will make the camera look "inwards" towards Pivot
        camera.transform.LookAt(transform);

        float speed = 10.0f;
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * speed);
        transform.Rotate(Vector3.left, Input.GetAxis("Vertical") * speed);
    }

    private Vector2 touchPosition;
    private float swopeResistance = 200.0f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            touchPosition = Input.mousePosition;

        }
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            float swipeForce = touchPosition.x - Input.mousePosition.x;
            if (Mathf.Abs(swipeForce) > swipeResistance)
            {
                if (swipeForce > 0)
                    SlideCamera(true);
                else
                    SlideCamera(false);
            }

        }
    } */

}
