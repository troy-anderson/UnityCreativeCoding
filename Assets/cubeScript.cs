using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour {


    public float rotateSpeed;

    //how fast cubes spin on their own internal axis
    public Vector3 spinSpeed;
    public Vector3 spinAxis;
    public int assignValue;
    
	void Start () {
        spinSpeed = new Vector3 (Random.value, Random.value, Random.value);
        spinAxis = Vector3.up;
        spinAxis.x = (Random.value - Random.value)*.1f;
    }

    public void SetSize(float size) {
        this.transform.localScale = new Vector3(size, size, size); 
    }
	
    public void AssignCubeNumber(int i)
    {
        assignValue = i;
        StartCoroutine(ChangeColor());

    }
    IEnumerator ChangeColor()
    {
        yield return new WaitForSeconds(assignValue);
        this.transform.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
    }
    void Update () {

        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed);

    }
}
