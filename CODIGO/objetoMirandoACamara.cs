using UnityEngine;
using System.Collections;

public class objetoMirandoACamara : MonoBehaviour {
    public Camera cam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var point = cam.transform.position;
        point.y = transform.position.y;
        transform.LookAt(point);
        }
}
