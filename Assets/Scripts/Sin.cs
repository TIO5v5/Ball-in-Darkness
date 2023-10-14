using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sin : MonoBehaviour
{

        public float Frequency = 1f;
        public float Amplitude = 1f;
        public float Offset = 1f;

        public Vector3 _startScale;
        private void Start()
        {
        transform.localScale = _startScale;
        }
        void Update()
        {
            //transform.localPosition = new Vector3(0f, Mathf.Sin(Time.time * 5f) / 10f , 0f);
            transform.localScale = _startScale * (Mathf.Sin(Time.time * Frequency * 2 * Mathf.PI) * Amplitude + Offset);


        }


}
