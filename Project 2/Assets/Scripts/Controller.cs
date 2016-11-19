using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public Material[] materials;
    private MeshRenderer renderer;

    // Use this for initialization
    void Start () {
        renderer = GetComponent<MeshRenderer>();
        renderer.material = materials[0];
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            renderer.material = materials[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            renderer.material = materials[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            renderer.material = materials[2];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            renderer.material = materials[3];
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            renderer.material = materials[4];
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            renderer.material = materials[5];
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CubeScript cubeScript = GetComponent<CubeScript>();
            cubeScript.speed -= 1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CubeScript cubeScript = GetComponent<CubeScript>();
            cubeScript.speed += 1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera cam = Camera.main;
            if (cam.orthographic)
            {
                cam.orthographic = false;
            } else
            {
                cam.orthographic = true;
            }
        }
    }
}
