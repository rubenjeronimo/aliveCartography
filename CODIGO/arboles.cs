using UnityEngine;
using System.Collections;

public class arboles : MonoBehaviour {
    public Terrain terreno;
    public Canvas LeyendaCanvas;
    public Canvas ArbolesCanvas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void arbolesON()
    {
        terreno.drawTreesAndFoliage=true;
        LeyendaCanvas.gameObject.SetActive(false);
        ArbolesCanvas.gameObject.SetActive(false);
    }
    public void arbolesOFF()
    {
        terreno.drawTreesAndFoliage = false;
        LeyendaCanvas.gameObject.SetActive(false);
        ArbolesCanvas.gameObject.SetActive(false);
    }
}
