using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
{
	public GameObject[] Fruits = new GameObject[5]; // set fruits' object
	public Vector3 RandomPosition;// fruits' random position 
	public float minTime = 0f; // mintime for spawn
	public float maxTime = 3f; // maxtime for spawn

	private float time; // reset spawntime
	private float spawnTime; // random spawntime

	void Start()
	{
		randomTime ();
		time = minTime;
	}
		
	void Update()
	{
		time += Time.deltaTime; // count time

		if (time >= spawnTime) // to spawn fruits
        {
            SpawnFruit ();
			randomTime ();
		}
	}


	void SpawnFruit()
	{
		int amount = Random.Range (0, 3); // to random how many fruits to create

		for (int i = 0;i<=amount;i++)
        {
            //RandomPosition = new Vector3 (Random.Range (-5f, 5f), 5f, 0f); // random position
            RandomPosition = new Vector3(Random.Range(-8.5f, 8.5f), 10f, 0f);
            //RandomPosition = new Vector3(Random.Range(-8.5f, 8.5f), 10f, 0f);
            int j = Random.Range (0, Fruits.Length); // choose a fruit

		    GameObject fruit = Instantiate(Fruits[j], RandomPosition, transform.rotation) as GameObject; // create fruits
		    //fruit.transform.Rotate(  Random.Range(-360, 360)  ,Random.Range(-360, 360),Random.Range(-360, 360) ); // make fruits rotate
		}
		time = 0; // reset time
	}

	void randomTime()
	{
		spawnTime = Random.Range(minTime,maxTime);
	}

}
