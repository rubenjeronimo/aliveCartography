using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


namespace DigitalRubyShared
{
    public class MovimientoCamara : MonoBehaviour
    {
        //
        // VARIABLES
        //

        public float turnSpeed = 4.0f;      // Speed of camera turning when mouse moves in along an axis
        public float panSpeed = 4.0f;       // Speed of the camera when being panned
        public float zoomSpeed = 4.0f;      // Speed of the camera going back and forth

        private Vector3 mouseOrigin;    // Position of cursor when mouse dragging starts
        private bool isPanning;     // Is the camera being panned?
        private bool isRotating;    // Is the camera being rotated?
        private bool isZooming;     // Is the camera zooming?
        public float distanceMin;
        public float distanceMax;

        public FingersScript FingerScript;
        private ScaleGestureRecognizer scaleGesture;
        private RotateGestureRecognizer rotateGesture;
        //
        // UPDATE
        //
        private void Start()
        {
           // CreateScaleGesture();
          //  CreateRotateGesture();
          //  scaleGesture.AllowSimultaneousExecution(rotateGesture);
        }
        void Update()
        {
            // Get the left mouse button
            if (Input.GetMouseButtonDown(0))
            {
                // Get mouse origin
                mouseOrigin = Input.mousePosition;
                isRotating = true;
            }
      
        
            


            // Get the right mouse button
            if (Input.GetMouseButtonDown(1))
            {
                // Get mouse origin
                mouseOrigin = Input.mousePosition;
                isPanning = true;
            }

            // Get the middle mouse button
            if (Input.GetMouseButtonDown(2))
            {
                // Get mouse origin
                mouseOrigin = Input.mousePosition;
                isZooming = true;
            }

            // Disable movements on button release
            if (!Input.GetMouseButton(0)) isRotating = false;
            if (!Input.GetMouseButton(1)) isPanning = false;
            if (!Input.GetMouseButton(2)) isZooming = false;

            // Rotate camera along X and Y axis
            if (isRotating)
            {
                Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

                transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
                transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
            }

            // Move the camera on it's XY plane
            if (isPanning)
            {
                Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

                Vector3 move = new Vector3(pos.x * panSpeed, pos.y * panSpeed, 0);
                transform.Translate(move, Space.Self);
            }

            // Move the camera linearly along Z axis
            if (isZooming)
            {
                Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

                Vector3 move = pos.y * zoomSpeed * transform.forward;
                transform.Translate(move, Space.World);
            }
        }
        /*
        private void ScaleGestureCallback(GestureRecognizer gesture, ICollection<GestureTouch> touches)
    {
        if (gesture.State == GestureRecognizerState.Executing)
        {
            Debug.Log("escala");
            //DebugText("Scaled: {0}, Focus: {1}, {2}", scaleGesture.ScaleMultiplier, scaleGesture.FocusX, scaleGesture.FocusY);
            //Earth.transform.localScale *= scaleGesture.ScaleMultiplier;
        }
    }

    private void CreateScaleGesture()
    {
        scaleGesture = new ScaleGestureRecognizer();
        scaleGesture.Updated += ScaleGestureCallback;
        FingerScript.AddGesture(scaleGesture);
    }

    private void RotateGestureCallback(GestureRecognizer gesture, ICollection<GestureTouch> touches)
    {
        if (gesture.State == GestureRecognizerState.Executing)
        {
            //Earth.transform.Rotate(0.0f, 0.0f, rotateGesture.RotationRadiansDelta * Mathf.Rad2Deg);
        }
    }

    private void CreateRotateGesture()
    {
        rotateGesture = new RotateGestureRecognizer();
        rotateGesture.Updated += RotateGestureCallback;
        FingerScript.AddGesture(rotateGesture);
    }
    */
    }

    }

       
    
