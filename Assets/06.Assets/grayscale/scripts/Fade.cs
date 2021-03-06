using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyGameStudio.Jeremy
{
    public class Fade : MonoBehaviour
    {
        [Header("show speed")]
        [Range(0, 5f)]
        public float speed_show;

        [Header("hide speed")]
        [Range(0, 5f)]
        public float hide_show;

        public Material _material;
        private bool is_showing=false;
        private bool is_hiding=false;
        private float blend = 0;


        [Header("min max threshold")]
        public float min_threshold;
        public float max_threshold;


        // Start is called before the first frame update
        void Start()
        {
            //if (this.GetComponent<MeshRenderer>() == null)
            //{
            //    this._material = this.GetComponent<SkinnedMeshRenderer>().material;
            //}
            //else
            //{
            //    this._material = this.GetComponent<MeshRenderer>().material;
            //}
        }

        public void reset_material()
        {
            if (this.GetComponent<MeshRenderer>() == null)
            {
                this._material = this.GetComponent<SkinnedMeshRenderer>().material;
            }
            else
            {
                this._material = this.GetComponent<MeshRenderer>().material;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (this.is_showing)
            {
                //this.threshold = Mathf.Lerp(this.threshold, this.min_threshold, Time.deltaTime * this.speed_show);

                this.blend -= Time.deltaTime * this.speed_show;

                if (this.blend <= this.min_threshold)
                {
                    this.blend = this.min_threshold;

                    this.is_showing = false;
                }

                this._material.SetFloat("_blend", this.blend);
            }

            if (this.is_hiding)
            {
                //this.threshold = Mathf.Lerp(this.threshold, this.max_threshold, Time.deltaTime * this.speed_show);

                this.blend += Time.deltaTime * this.speed_show;

                if (this.blend >= this.max_threshold)
                {
                    this.blend = this.max_threshold;

                    this.is_hiding = false;
                }
                this._material.SetFloat("_blend", this.blend);
            }
        }

        public void show()
        {
            this.is_hiding = false;

            this.blend = this.max_threshold;

            this._material.SetFloat("_blend", this.blend);

            this.is_showing = true;
        }

        public void hide()
        {
            this.is_showing = false;

            this.blend = this.min_threshold;

            this._material.SetFloat("_blend", this.blend);

            this.is_hiding = true;
        }
    }
}