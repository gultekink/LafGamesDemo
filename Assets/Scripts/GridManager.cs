using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

    public class GridManager : MonoBehaviour
    {
        [SerializeField] private float x_Start, y_Start;
        [SerializeField] private int _column, _row;
        [SerializeField] private float x_space, y_space;
        [SerializeField] private GameObject _block;
        [SerializeField] private GameObject _rightArrow;
        [SerializeField] private GameObject _downArrow;
        [SerializeField] private GameObject _leftArrow;
        [SerializeField] private GameObject _topArrow;
        [SerializeField] private float _rightStartx, _rightStarty;
        [SerializeField] private float _leftStartx, _leftStarty;
        [SerializeField] private float _topStartx, _topStarty;
        [SerializeField] private float _downStartx, _downStarty;

        void Start()
        {
            GenerateGrid();
            GenerateArrows();

        }

        private void GenerateGrid()
        {
            for (int i = 0; i < _column * _row; i++)
            {
                Instantiate(_block, new Vector3(x_Start + (x_space * (i % _column)), y_Start + (-y_space * (i / _column))), Quaternion.identity);
            }

        }

        private void GenerateArrows()
        {
            //RightArrow
            for (int i = 0; i < _column; i++)
            {
                Instantiate(_rightArrow, new Vector3(_rightStartx + (x_space * (i % 1)), _rightStarty + (-y_space * (i / 1))), Quaternion.identity);
            }
            //LeftArrow
            for (int i = 0; i < _column; i++)
            {
                Instantiate(_leftArrow, new Vector3(_leftStartx + (x_space * (i % 1)), _leftStarty + (-y_space * (i / 1))), Quaternion.identity);
            }
            //DownArrow
            for (int i = 0; i < _column; i++)
            {
                Instantiate(_downArrow, new Vector3(_downStartx + (x_space * (i % _column)), _downStarty + (-y_space * (i / _column))), Quaternion.identity);
                _downArrow.transform.rotation = Quaternion.Euler(0, 0, -90);

            }
            //TopArrow
            for (int i = 0; i < _column; i++)
            {
                Instantiate(_topArrow, new Vector3(_topStartx + (x_space * (i % _column)), _topStarty + (-y_space * (i / _column))), Quaternion.identity);
            }
        }

    }


