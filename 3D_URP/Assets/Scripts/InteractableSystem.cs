using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
namespace bearfall
{
    /// <summary>
    /// 互動系統:偵測玩家是否進入並且執行互動行為
    /// </summary>

    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("第一段對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("對話結束後的事件")]
        private UnityEvent onDialogueFinish;
        [SerializeField, Header("啟動道具")]
        private GameObject propActive;
        [SerializeField, Header("啟動後的對話資料")]
        private DialogueData dataDialogueActive;
        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;
        
        [SerializeField, Header("啟動後對話結束後的事件")]
        private UnityEvent onDialogueFinishAfterActive;


        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
        }

        public void HitByRaycast() //被射線打到時會進入此方法
        {
            if (Input.GetKeyDown(KeyCode.E)) //當按下鍵盤 E 鍵時
            {
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive, onDialogueFinishAfterActive);
                }
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name.Contains(nameTarget))
            {
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive, onDialogueFinishAfterActive);
                }
            }
        }
        

        
        // Start is called before the first frame update
        

        

        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }
    }
}