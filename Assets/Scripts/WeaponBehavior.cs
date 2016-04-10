using UnityEngine;
using System.Collections;

public class WeaponBehavior : MonoBehaviour {

    GameObject player;

    public GameObject weaponFront;
    public GameObject weaponBack;
    public GameObject weaponLeft;
    public GameObject weaponRight;

    GameObject actualAttack;

    private bool attacking = false;
    private float fireRate = 0.5f;
    private float nextAttack = 0.0f;
    private float timeSpawn = 0.25f;
    private string playerFacing = "";

    void Start() {
        player = GameObject.FindWithTag("Player");
    }

    void Attack() {
        switch (playerFacing) {
            case "front":
                FrontAttack();
                break;

            case "back":
                BackAttack();
                break;

            case "left":
                LeftAttack();
                break;

            case "right":
                RightAttack();
                break;
        }
        
        nextAttack = Time.time + fireRate;
        Destroy(actualAttack, timeSpawn);
    }

    void Update() {
        playerFacing = player.GetComponent<GridMovement>().getFacing();

        Debug.Log(playerFacing);

        if (Input.GetKey(KeyCode.Space) && Time.time > nextAttack) {
            Attack();
        }
    }

    void FrontAttack() {
        Vector3 pos = player.transform.position + new Vector3(0, 1, 0);
        actualAttack = Instantiate(weaponFront, pos, Quaternion.identity) as GameObject;
        Debug.Log(pos);
    }

    void BackAttack() {
        Vector3 pos = player.transform.position + new Vector3(0, -1, 0);
        actualAttack = Instantiate(weaponBack, pos, Quaternion.identity) as GameObject;
    }

    void LeftAttack() {
        Vector3 pos = player.transform.position + new Vector3(-1, 0, 0);
        actualAttack = Instantiate(weaponLeft, pos, Quaternion.identity) as GameObject;
    }

    void RightAttack() {
        Vector3 pos = player.transform.position + new Vector3(1, 0, 0);
        actualAttack = Instantiate(weaponRight, pos, Quaternion.identity) as GameObject;
    }
}
