using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placement : MonoBehaviour
{
    public bool selected;
    public GameObject Turret;
    public GameObject Cube;
    public int TurretCost;
    public bool Placeable;

    public Material Gray;
    public Material StartingMaterial;
    public Renderer rend;
    public Renderer rendOnMouseEnter;

    // Start is called before the first frame update
    void Start()
    {
        Placeable = true;
        rend = GetComponent<Renderer>();
        StartingMaterial = rend.material;
    }

    // Update is called once per frame
    void Update()
    {
        if(selected == true && Input.GetKeyDown("t") && Placeable == true)
        {
            //Debug.Log("Posicion es : x " + Cube.transform.position.x + " y : " + Cube.transform.position.y + " z: " + Cube.transform.position.z);
            Instantiate(Turret, new Vector3(Cube.transform.position.x, Cube.transform.position.y + 0.5f, Cube.transform.position.z), Quaternion.identity);
            Placeable = false;
        }
    }

    public void OnMouseDown()
    {
        selected = true;
    }

    public void OnMouseExit()
    {
        selected = false;
        rendOnMouseEnter = GetComponent<Renderer>();
        rendOnMouseEnter.material = StartingMaterial;
    }

    public void OnMouseEnter()
    {
        rendOnMouseEnter = GetComponent<Renderer>();
        rendOnMouseEnter.material = Gray;
    }
}
