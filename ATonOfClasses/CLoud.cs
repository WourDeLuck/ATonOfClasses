using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATonOfClasses
{
    /// <summary>
    /// Cloud class.
    /// Contains basic information to store data.
    /// </summary>
    public class Cloud
    {
        // Number of the cloud. Getting easier to manipulate data of specific clouds. Type "uint" was chosen to prevent from having negative values.
        private uint _id;
        // Allows to indicate any type of cloud. Type "string" helps to type any scientific kind of clouds.
        private string _type;
        // Since every cloud has its own specific size, it's easier to use "ushort" to indicate its size. "ushort" also prevents from having negative values.
        private ushort _size;
        // Every cloud is unique because of its shape. Type "string" helps to describe the shape.
        private string _shape;
        // Clouds are moving with the help of wind. But depending on height there could be different wind speeds. That's why I used "ushort" to describe the speed of clouds.
        private ushort _moveSpeed;
        // Clouds might be located on different heights. Type "ushort" helps to indicate it correctly.
        private ushort _height;
        // The status of a cloud is determining by its movement speed.
        private StatusCondition _status;

        // Used properties to encapsulate fields.
        public uint Id { get => _id; set => _id = value; }
        public string Type { get => _type; set => _type = value; }
        public ushort Size { get => _size; set => _size = value; }
        public string Shape { get => _shape; set => _shape = value; }
        public ushort MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
        public ushort Height { get => _height; set => _height = value; }
        public StatusCondition Status { get => _status; }

        // Enum class for the status was chosen to allow user to pick one of two conditions: "moving" and "staying".
        public enum StatusCondition
        {
            Moving,
            Staying
        };

        // Class constructor including basic parameters for the cloud class.
        public Cloud(uint id, string type, ushort size, string shape, ushort moveSpeed, ushort height)
        {
            _id = id;
            _type = type;
            _size = size;
            _shape = shape;
            _moveSpeed = moveSpeed;
            _height = height;
        }

        /// <summary>
        /// Returns cloud's condition.
        /// </summary>
        /// <param name="moveSpeed">Stores speed of cloud.</param>
        public void ChangeCondition(ushort moveSpeed)
        {
            switch (moveSpeed)
            {
                // If cloud's moving speed is 0, the condition is "staying".
                case 0:
                    _status = StatusCondition.Staying;
                    break;
                // In any other case the cloud is moving.
                default:
                    _status = StatusCondition.Moving;
                    break;
            }
        }
    }
}
