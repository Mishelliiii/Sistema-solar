using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giraGira : MonoBehaviour {

  // Use this for initialization

  Vector3 rotacao;

  public float anguloX, anguloY, anguloZ;
	void Start ()
  {
    
	}
	
	// Update is called once per frame
	void Update ()
  {
    rotacao = new Vector3(
                    anguloX * Time.deltaTime,
                    anguloY * Time.deltaTime,
                    anguloZ * Time.deltaTime
                    );

    transform.Rotate(rotacao);
	}
}
