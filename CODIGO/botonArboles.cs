using UnityEngine;
using System.Collections;

public class botonArboles : MonoBehaviour {
    public Canvas ArbolesCanvas;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MuestraMenu()
    {
        ArbolesCanvas.gameObject.SetActive(true);
    }
}
