using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LetGroupByToAnonymous
{
    public class TerminalRestriction
    { 
        public TerminalRestriction()
        {

        }

        [NotMapped]
        public IEnumerable<Member> Members { get; set; }
        public Member RestrictionCreater
        {
            get
            {
                try
                {
                    return this.Members.First();
                }
                catch
                {
                    return new Member() {  };
                }
            }
        }

        [JsonIgnore]
        public int TerminalId { get; set; }

        public DateTime Date { get; set; }

        public int MaxVehiclesCount { get; set; }
        public int VehiclesCount { get; set; }

        public override string ToString()
        {
            return $"{TerminalId}, {Date:dd.MM.yyyy}, ({base.ToString()}) ({MaxVehiclesCount}/{VehiclesCount})";
        }
    }
}
