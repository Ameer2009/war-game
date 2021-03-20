using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{

public GameObject body;

public GameObject mainarm;

public GameObject tank;

public GameObject tank2;

public GameObject bomb;


float tankspeed = 7;

float speed = 75;

float bomb_speed;

bool is_powering_bomb = false;

    void Start()
    {
        
    }


    void Update()
    {

if (Input.GetKey(KeyCode.DownArrow)) {
    mainarm.transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
}
else if (Input.GetKey(KeyCode.UpArrow)) {
    mainarm.transform.Rotate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }
if (Input.GetKey(KeyCode.LeftArrow)) {
    body.transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
    }
    else if (Input.GetKey(KeyCode.RightArrow)) {
    body.transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
    }
if (Input.GetKey(KeyCode.W)) {
    tank.transform.position += new Vector3(0, 0, tankspeed * Time.deltaTime);
}
else if (Input.GetKey(KeyCode.S)) {
    tank.transform.position -= new Vector3(0, 0, tankspeed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.A)) {
    tank.transform.position -= new Vector3(tankspeed * Time.deltaTime, 0, 0);
}
else if (Input.GetKey(KeyCode.D)) {
    tank.transform.position += new Vector3(tankspeed * Time.deltaTime, 0, 0);
    }

    if (Input.GetKeyDown(KeyCode.Space)) {
bomb_speed = 50;
is_powering_bomb = true;
}
if (is_powering_bomb) {
bomb_speed += .1f;
}
    if (Input.GetKeyUp(KeyCode.Space)) {
is_powering_bomb = false;
  
     if (bomb_speed > 50) bomb_speed = 50;

GameObject new_bomb = Instantiate(bomb);
new_bomb.transform.position = mainarm.transform.position;
new_bomb.GetComponent<Rigidbody>().velocity = mainarm.transform.up * 20;
 
  
    }

    }
}