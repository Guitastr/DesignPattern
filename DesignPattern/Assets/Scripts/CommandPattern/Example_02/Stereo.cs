using UnityEngine;

namespace Assets.Scripts.CommandPattern.Example_02
{
    public class Stereo
    {
        private string _name;
        public Stereo(string name)
        {
            _name = name;
        }

        public void On()
        {
            Debug.Log(_name + " Stereo is On");
        }

        public void Off()
        {
            Debug.Log(_name + "Stereo is Off");
        }

        public void SetCD()
        {
            Debug.Log(_name + " Stereo is SetCD");
        }

        public void SetVolume(int magnitude)
        {
            Debug.Log(_name + " Stereo is SetVolume" + magnitude);
        }
    }
}