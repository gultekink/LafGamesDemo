using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class ButtonManager : MonoBehaviour
    {
        [SerializeField] private Button _unitButton2;
        [SerializeField] private Button _unitButton3;
        [SerializeField] private Button _unitButton4;

        public static int currentSelection;

        // Start is called before the first frame update
       public void Start()
        {
            Button btn2 = _unitButton2.GetComponent<Button>();
            Button btn3 = _unitButton3.GetComponent<Button>();
            Button btn4 = _unitButton4.GetComponent<Button>();
            btn2.onClick.AddListener(UnitButton2);
            btn3.onClick.AddListener(UnitButton3);
            btn4.onClick.AddListener(UnitButton4);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void UnitButton2()
        {
            currentSelection = 2;
        }

        void UnitButton3()
        {
            currentSelection = 3;
        }

        void UnitButton4()
        {
            currentSelection = 4;
        }
    }


