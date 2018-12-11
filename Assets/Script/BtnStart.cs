using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnStart : MonoBehaviour {

	public GameObject MenuCanvas;
	public GameObject GameCanvas;
	public GameObject CameraRotation;
	public GameObject HPValue;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClickStart() {
		MenuCanvas.gameObject.SetActive(false);
		GameCanvas.gameObject.SetActive(true);

		GameObject CameraRotateSpeed = GameObject.Find("Rotate Camera");
		CameraRotator cameraRotatorScript = CameraRotateSpeed.GetComponent<CameraRotator>();
		cameraRotatorScript.speed = 0;
		CameraRotation.transform.rotation = Quaternion.Euler(0, 0, 0);
		HPValue.GetComponent<UnityEngine.UI.Text>().text = "200"; // later get from public variable for HP
	}
}
