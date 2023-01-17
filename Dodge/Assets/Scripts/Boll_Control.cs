using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boll_Control : MonoBehaviour
{
    public float bollSpeed = 8.0f;
    private Rigidbody bollRgBody = default;
    // Start is called before the first frame update
    void Start()
    {
        bollRgBody = gameObject.GetComponent<Rigidbody>();
        bollRgBody.velocity = transform.forward * bollSpeed;

        // 총알이 3초 동안 있다가 사라진다.
        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            Player_Controler Player = other.GetComponent<Player_Controler>();
            if(Player == null || Player == default)
            {
                return;
            }
            
            // 플레이어의 컨트롤을 정상적으로 가져온 경우
            // 총알을 맞은 플레이어는 죽는다.
            Player.Die();
        } // if: 태그가 플레이어인 경우
        

    }
}
