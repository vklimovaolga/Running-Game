using UnityEngine;
using System.Collections;

public class Rodar2 : MonoBehaviour {
	
	
	void Update () {
        transform.Rotate(new Vector3(0, 0,10) * Time.deltaTime * 6);
        transform.Translate(new Vector3(0, 0, Mathf.Sin(Time.time * 8)) * Time.deltaTime);
        //Mathf.Sin(Time.time * 8)

    }
}
