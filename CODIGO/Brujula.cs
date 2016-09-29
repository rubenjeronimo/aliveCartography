using UnityEngine;
using System.Collections;

public class Brujula : MonoBehaviour {
    public Camera camara;
    public GameObject brujula;
    public float azimut = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        azimut = camara.gameObject.transform.eulerAngles.y;
        //print(azimut);
        brujula.transform.eulerAngles=new Vector3(0,azimut, 0);

    }
}
