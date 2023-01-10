using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
namespace bearfall
{

    public class DestoryPlayer : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        private PlayerInput playerInput;
        
        
        
        void Start()
        {
            playerInput = GameObject.Find("PlayerCapsule").GetComponent<PlayerInput>();
            
        }
        private void OnCollisionEnter(Collision other)
        {
            print("�I��:" + other.gameObject);
            if (other.gameObject.name.Contains(nameTarget))
            {
                FinalManager.instance.GameOver("�A�w���`");
               
                playerInput.enabled = false;
            }
        }
       
        // Update is called once per frame
        void Update()
        {

        }
    }
}