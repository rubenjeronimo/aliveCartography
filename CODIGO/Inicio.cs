using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {
    public Canvas MaterialCanvas;
    public Canvas CurvasDeNivelCanvas;
    public GameObject curvasDeNivelObjeto;
    public GameObject LeyendaCanvas;
    public GameObject ArbolesCanvas;
    public GameObject AguaCanvas;
    public GameObject AyudaCanvas;
    public GameObject EdificiosCanvas;
    public GameObject conceptualCanvas;
    public GameObject conceptualObjeto;

    // Use this for initialization
    void Start () {
        MaterialCanvas.gameObject.SetActive(false);
        AyudaCanvas.gameObject.SetActive(false);
        LeyendaCanvas.gameObject.SetActive(false);
        ArbolesCanvas.gameObject.SetActive(false);
        AguaCanvas.gameObject.SetActive(false);
        CurvasDeNivelCanvas.gameObject.SetActive(false);
        curvasDeNivelObjeto.gameObject.SetActive(false);
        EdificiosCanvas.gameObject.SetActive(false);
        conceptualCanvas.gameObject.SetActive(false);
        conceptualObjeto.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
