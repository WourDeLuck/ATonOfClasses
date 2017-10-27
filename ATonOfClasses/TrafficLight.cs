using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATonOfClasses
{
    /// <summary>
    /// Traffic light class.
    /// Contains basic information to store data.
    /// </summary>
    public class TrafficLight
    {
        // Used to identify the traffic light. Type "uint" is used to prevent from having negative values.
        private uint _id;
        // Used to name the type of the traffic light.
        private string _type;
        // Used to indicate the location of the traffic light (usually streets).
        private string _location;
        // Different types of traffic lights use different lamps type. F.E. LED.
        private string _lampsType;
        // This list combines the color of a light and its status. Makes easier to identify the work status of every light there.
        private List<Light> _lightsInfo = new List<Light>();
        // Is used to indicate the status of the traffic light if it's working or not.
        private string _workStatus;

        // Used properties to encapsulate fields.
        public List<Light> LightsInfo { get => _lightsInfo; set => _lightsInfo = value; }
        public uint Id { get => _id; set => _id = value; }
        public string Type { get => _type; set => _type = value; }
        public string Location { get => _location; set => _location = value; }
        public string LampsType { get => _lampsType; set => _lampsType = value; }
        public string WorkStatus { get => _workStatus; set => _workStatus = value; }

        // Class made for the "Light" list. Contains two parametres.
        public class Light
        {
            // Is used to define a light color. String is used there because not every type of traffic light has one set of light colors.
            private string _lightColor;
            // Is used to indicate the status of a light.
            private string _status;

            // Used properties to encapsulate fields.
            public string LightColor { get => _lightColor; set => _lightColor = value; }
            public string Status { get => _status; set => _status = value; }
        }

        // Class constructor including basic parameters for the traffic light class.
        public TrafficLight(uint id, string type, string location, string lampsType, string workStatus)
        {
            _id = id;
            _type = type;
            _location = location;
            _lampsType = lampsType;
            _lightsInfo = new List<Light>();
            _workStatus = workStatus;
        }       
    }
}
