using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;


public class InstantiateBlock : MonoBehaviour
    {
        [SerializeField] private GameObject m_2UnitBlock;
        [SerializeField] private GameObject m_3UnitBlock;
        [SerializeField] private GameObject m_4UnitBlock;
        private float _blockDegree = -90;
        private GameObject _currentBlock;
        private float _distance;

    void Update()
    {
        if (ButtonManager.currentSelection == 2)
        {
            _currentBlock = m_2UnitBlock;
            _distance = 1f;

        }else if (ButtonManager.currentSelection == 3)
        {
            _currentBlock = m_3UnitBlock;
            _distance =1.5f;

        }else if (ButtonManager.currentSelection == 4)
        {
            _currentBlock = m_4UnitBlock;
            _distance = 2f;
        }
    }


    void OnMouseDown()
        {
            
            if (gameObject.name == "DownArrow(Clone)")
            {
                RaycastHit hit;
                Ray ray = new Ray(transform.position,-gameObject.transform.up);
                if (Physics.Raycast(ray, out hit, _distance))
                {
                Debug.Log("The block is oversize. Please change your selection.");

            }
                else
                {
                    var instance = Instantiate(_currentBlock, gameObject.transform.position,Quaternion.Euler(new Vector3(0, 0, -180)));
                    instance.GetComponent<Rigidbody>().AddForce(new Vector3(0, -1) * 3, ForceMode.Impulse);
                }
            }else if (gameObject.name == "TopArrow(Clone)")
            {
                RaycastHit hit;
                Ray ray = new Ray(transform.position, gameObject.transform.up);
                if (Physics.Raycast(ray, out hit, _distance))
                {
                Debug.Log("The block is oversize. Please change your selection.");
            }
                else
                {
                    var instance = Instantiate(_currentBlock, gameObject.transform.position, Quaternion.identity);
                    instance.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1) * 3, ForceMode.Impulse);
                }

            }else if (gameObject.name == "LeftArrow(Clone)")
            {

            RaycastHit hit;
            Ray ray = new Ray(transform.position, -gameObject.transform.right);

            if (Physics.Raycast(ray, out hit, _distance))
            {
                Debug.Log("The block is oversize. Please change your selection.");
            }
            else
            {
                var instance = Instantiate(_currentBlock, gameObject.transform.position, Quaternion.Euler(new Vector3(0, 0, -270)));
                instance.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0) * 3, ForceMode.Impulse);

                
            }
           
            }else if (gameObject.name == "RightArrow(Clone)")
            {
                RaycastHit hit;
                Ray ray = new Ray(transform.position, gameObject.transform.right);
                if (Physics.Raycast(ray, out hit, _distance))
                {
                Debug.Log("The block is oversize. Please change your selection.");
            }
                else
                {
                    var instance = Instantiate(_currentBlock, gameObject.transform.position,
                        Quaternion.Euler(new Vector3(0, 0, _blockDegree)));
                    instance.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0) * 3f, ForceMode.Impulse);
                }
            }

        }

    }

