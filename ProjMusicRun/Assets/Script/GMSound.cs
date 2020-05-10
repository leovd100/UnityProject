﻿using UnityEngine;
using System.Collections;

public class GMSound : MonoBehaviour {
	public GameObject[] repoObj = new GameObject[512];
	public GameObject[] targets;

	private float[] spectrum;
	private int i,j,g;
	private float timeToSpawn;

	static public bool stopCubes;
	// Use this for initialization
	void Start () {
		i = Random.Range(0,512);
		j = Random.Range(0,2);
		g = Random.Range(0,targets.Length);
	}
	
	// Update is called once per frame
	void Update () {
		if (!stopCubes){
		timeToSpawn -= Time.deltaTime;
		spectrum = AudioListener.GetSpectrumData(512,0,FFTWindow.Hamming);


		if (spectrum[i] *30 > 0.02f && timeToSpawn <= 0){
			Instantiate (repoObj[j],targets[g].transform.position,targets[0].transform.rotation);
			j = Random.Range(0,2);
				i = Random.Range(0,spectrum.Length);
				g = Random.Range(0,targets.Length);
			timeToSpawn = 0.3f;
		   }

		if (spectrum[i] *30> 0.01f && timeToSpawn <= 0){

			Instantiate (repoObj[j],targets[g].transform.position,targets[0].transform.rotation);
			j = Random.Range(0,2);
				i = Random.Range(0,spectrum.Length);
				g = Random.Range(0,targets.Length);
			timeToSpawn = 0.3f;
			}

		if (spectrum[i] *30> 0.015f && timeToSpawn <= 0){
	
			Instantiate (repoObj[j],targets[g].transform.position,targets[0].transform.rotation);
			j = Random.Range(0,2);
				i = Random.Range(0,spectrum.Length);
				g = Random.Range(0,targets.Length);
			timeToSpawn = 0.3f;
			}

		if (spectrum[i] *30> 0.009f && timeToSpawn <= 0){
		
			Instantiate (repoObj[j],targets[g].transform.position,targets[0].transform.rotation);
			j = Random.Range(0,2);
				i = Random.Range(0,spectrum.Length);
				g = Random.Range(0,targets.Length);
			timeToSpawn = 0.3f;

			}

		}









	}
}
