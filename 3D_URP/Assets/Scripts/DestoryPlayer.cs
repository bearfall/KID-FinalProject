using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
namespace bearfall
{

    public class DestoryPlayer : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        private PlayerInput playerInput;
        
        
        
        void Start()
        {
            playerInput = GameObject.Find("PlayerCapsule").GetComponent<PlayerInput>();
            
        }
        private void OnCollisionEnter(Collision other)
        {
            print("碰撞:" + other.gameObject);
            if (other.gameObject.name.Contains(nameTarget))
            {
                FinalManager.instance.GameOver("你已死亡");
               
                playerInput.enabled = false;
            }
        }
       
        // Update is called once per frame
        void Update()
        {

        }
    }
}