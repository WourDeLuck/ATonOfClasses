using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATonOfClasses
{
    /// <summary>
    /// Law of Physics class.
    /// Contains basic information to store data.
    /// </summary>
    public class LawOfPhysics
    {
        // Allows to indicate the name of a law. Basic "string" is being used just right.
        private string _name;
        // Used string to name the authors who discovered the law.
        private string _authors;
        // Allows to indicate the year of discovering. Type "uint" prevents from having negative values.
        private uint _discoverDate;
        // String is used to indicate a short description to the law.
        private string _description;
        // Dictionary collection was created to store formulas related to a specific law. Having "TValue" allows to delete formulas by their specific values.
        private Dictionary<string, int> _formulas;

        // Used properties to encapsulate fields.
        public string Name { get => _name; set => _name = value; }
        public string Authors { get => _authors; set => _authors = value; }
        public uint DiscoverDate { get => _discoverDate; set => _discoverDate = value; }
        public string Description { get => _description; set => _description = value; }
        public Dictionary<string, int> Formula { get => _formulas; }

        // Class constructor including basic parameters for the physics law class.
        public LawOfPhysics(string name, string authors, uint discoverDate, string description)
        {
            _name = name;
            _authors = authors;
            _discoverDate = discoverDate;
            _description = description;
            _formulas = new Dictionary<string, int>();
        }
    }
}
