using UnityEngine;

namespace Assets.Scripts.CommandPattern.Example_02
{
    public class GarageDoor
    {
        private string _name;

        public GarageDoor(string name)
        {
            _name = name;
        }

        public void On()
        {
            Debug.Log(_name + " GarageDoor is On");
        }

        public void Off()
        {
            Debug.Log(_name + " GarageDoor is Off");
        }
    }
}