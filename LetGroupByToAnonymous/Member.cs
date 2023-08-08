using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LetGroupByToAnonymous
{
    public class Member
    {
        public Member()
        {

        }

        [Required] public int MemberId { get; set; }

        public string? MemberInfo { get; set; }

        public int[] CargoOwnerIds { get; set; }

        public override bool Equals(object o)
        {
            switch (o)
            {
                case Member m: return this.MemberId.Equals(m.MemberId);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }

        public override string ToString()
        {
            return $"({MemberId})";
        }
    }
}
