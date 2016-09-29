using UnityEngine;
using System.Collections;

public class CurvasDeNivel : MonoBehaviour {
    public GameObject curvasDeNivelObjeto;
    public Canvas curvasDeNivelCanvas;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCurvasDeNivel()
    {
        curvasDeNivelObjeto.gameObject.SetActive(true);
        curvasDeNivelCanvas.gameObject.SetActive(false);
    }

    public void OffCurvasDeNivel()
    {
        curvasDeNivelObjeto.gameObject.SetActive(false);
        curvasDeNivelCanvas.gameObject.SetActive(false);
    }
}
