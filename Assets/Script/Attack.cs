using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
	public GameObject player;
	public GameObject projectile;
    public GameObject holyGround;
    public GameObject shuriken;
    private GameObject enemy;
    public float fireRate;
	public float nextFire;
	public int shurikenNumber;
	public bool shurikenAllowed;
	public bool holyGroundAllowed;
	public bool projectileAllowed;
	

	// This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        fireRate = 1.0f;  
		nextFire = 1.0f;
		shurikenNumber = 0;
		projectileAllowed = false;
		shurikenAllowed = false;
		holyGroundAllowed = false;
    }


    // Update is called once per frame
    void Update()
    {
	    enemy = GameObject.FindGameObjectWithTag("Enemy");
	    if (enemy == null) return;
		if(Time.time>nextFire) {
			// Instantiate at position (0, 0, 0) and zero rotation.
			if (projectileAllowed && enemy != null)
			{
				Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);
			}
       		
            if ((GameObject.FindGameObjectsWithTag("Shuriken").Length <= shurikenNumber) && shurikenAllowed)
            {
	            Instantiate(shuriken, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);
            }
            
            if ((GameObject.FindGameObjectsWithTag("HolyGround").Length == 0) && holyGroundAllowed)
            {
	            Instantiate(holyGround, new Vector3(player.transform.position.x, (player.transform.position.y), player.transform.position.z), Quaternion.identity);
            }
			nextFire = Time.time + fireRate;
		}
		
    }
}
