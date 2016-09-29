using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Medir : MonoBehaviour {
    public bool estoyMidiendo;
    public Button botonMedir;
    public Vector3 mousePosition;
    public Vector3 punto1;
    public Vector3 punto2;
    public float distancia;
    public float diferenciaAltura;
    public GameObject punto;

    // Use this for initialization
    void Start () {
        estoyMidiendo = false;
        
	}
	
	// Update is called once per frame
	void Update () {
        
        var mousex = (Input.mousePosition.x);
        var mousez = (Input.mousePosition.z);
        var mouseposition = Camera.main.ScreenToWorldPoint(new Vector3(mousex, 0, mousez));
       // print(mouseposition);
    }

    public void medir()
    {
        if (estoyMidiendo == false)
        {
            estoyMidiendo = true;
            //var mousex = (Input.mousePosition.x);
            //var mousez = (Input.mousePosition.z);
            //var mouseposition = Camera.main.ScreenToWorldPoint(new Vector3(mousex, 0, mousez));
            if (Input.GetMouseButtonDown(0))
            {
                mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
                Vector3 worldPos;
                Ray ray = Camera.main.ScreenPointToRay(mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray,out hit, 1000f))
                {
                    worldPos = hit.point;
                }
                else
                {
                    worldPos = Camera.main.ScreenToWorldPoint(mousePosition);
                }
                Instantiate(punto, worldPos, Quaternion.identity);

               Debug.Log(mousePosition);
                punto1 = mousePosition;
            }
            
            if (Input.GetMouseButtonDown(0))
            {
                mousePosition = Event.current.mousePosition;
                punto2 = mousePosition;
            }
            
           // distancia = Mathf.Sqrt(((punto2.x * punto2.x)- (punto1.x * punto1.x))+ ((punto2.z * punto2.z) - (punto1.z * punto1.z)));
            Debug.Log("punto1= " + punto1);
        }
        else if (estoyMidiendo== true)
        {
            estoyMidiendo = false;
            Debug.Log("NOmidiendo");
        }
    }
}
