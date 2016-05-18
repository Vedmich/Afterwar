using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CitizensList : MonoBehaviour 
{

	public List<CitizensData> citizens;
	public Citizen CitizenPrefab;

		
	void Start () 
	{
		int index = Random.Range(0, citizens.Count);

		Citizen newCit = Instantiate(CitizenPrefab);
		newCit.Init(citizens[index].name,3,3);

	}


}
