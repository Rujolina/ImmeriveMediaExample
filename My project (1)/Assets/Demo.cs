using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{

    public int myVar = 0;

    public bool isPressed = false;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go =Instantiate(prefab, Vector3.zero, Quaternion.identity);
        //go.GetComponent<Renderer>().material.color = Color.blue;
        go.GetComponent<Renderer>().material.color = GetRandomColor();
    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Input.mousePosition);


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse button pressed");
            isPressed = true;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 10000.0f))
            {
                Debug.Log("Hit gameobject: " + hit.transform.gameObject.name);
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse button pressed.");
            isPressed = false;
        }
    }

}
