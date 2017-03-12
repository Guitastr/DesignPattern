using UnityEngine;

namespace Assets.Scripts.CommandPattern.Example_02
{
    /// <summary>
    ///     厂商类
    /// </summary>
    public class Light
    {
        private readonly string _name;

        public Light(string name)
        {
            _name = name;
        }

        public void On()
        {
            Debug.Log(_name + " Light is On");
        }

        public void Off()
        {
            Debug.Log(_name + " Light is Off");
        }
    }
}