using UnityEngine;
using System.Collections;

public class botonLeyenda : MonoBehaviour {
    public Canvas LeyendaCanvas;
    public Canvas ArbolesCanvas;
    // Use this for initialization
    void Start()
    {
        ArbolesCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void MuestraMenu()
    {
        LeyendaCanvas.gameObject.SetActive(true);
    }
}
