using UnityEngine;
using System.Collections;

public class laser2 : MonoBehaviour {
    public Transform startPoint;
    public Transform endPoint;
    LineRenderer laserLine;

	// Use this for initialization
	void Start () {
        laserLine = GetComponent<LineRenderer>();
        laserLine.SetWidth(20f, 20f);

	
	}
	
	// Update is called once per frame
	void Update () {
        laserLine.SetPosition(0, startPoint.position);
        laserLine.SetPosition(1, endPoint.position);
	
	}
}
