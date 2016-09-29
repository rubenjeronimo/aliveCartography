using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class coordenadasCamara : MonoBehaviour {
    public Camera camara;
    public Text coordenadaX;
    public Text coordenadaY;
    public Text coordenadaZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var posicionCamara = camara.transform.position;
        float Xcamara = posicionCamara.x * 2.300f;//+ 306341.986f;
        float Ycamara = posicionCamara.z * 12.710f;//+ 4446886.654f;
        float Zcamara = posicionCamara.y + 376.364f;
        coordenadaX.text = Xcamara.ToString();
        coordenadaY.text = Ycamara.ToString();
        coordenadaZ.text = Zcamara.ToString();
    }
}
