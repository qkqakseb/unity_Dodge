using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controler : MonoBehaviour
{
    private Rigidbody PlayerRgBody = default;

    public float PlayerSpeed = 8.0f;
    public GameManager gameManager = default;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRgBody = gameObject.GetComponent<Rigidbody>();

        // Vector3 firstPoint = new Vector3(100f, 0f, 0f);
        // Vector3 secondPoint = new Vector3(500f, 0f, 0f);
        // float distance = (secondPoint - firstPoint).magnitude;
        // Debug.Log($"두 점 사이의 거리는 : {distance}");
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * PlayerSpeed;
        float zSpeed = zInput * PlayerSpeed;

        Vector3 PlayerVelo = new Vector3(xSpeed, 0f, zSpeed);

        PlayerRgBody.velocity = PlayerVelo;

        

        
    } // Update()

    // 이전에 움직이던 방식을 캐싱해 놓은 함수
    public void LegatMove() 
    { 
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            PlayerRgBody.AddForce(new Vector3(0, 0, PlayerSpeed));
        }
        if(Input.GetKey(KeyCode.DownArrow) == true)
        {
            PlayerRgBody.AddForce(new Vector3(0, 0, -PlayerSpeed));
        }
        if(Input.GetKey(KeyCode.RightArrow) == true)
        {
            PlayerRgBody.AddForce(new Vector3(PlayerSpeed, 0, 0));
        }
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            PlayerRgBody.AddForce(new Vector3(-PlayerSpeed, 0, 0));
        }
    }
     // 플레이어가 사망했을 때 호출하는 함수
     public void Die()
     {
        gameObject.SetActive(false);
        gameManager.EndGame();
     }
}
