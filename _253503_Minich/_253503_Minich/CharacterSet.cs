using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _253503_Minich
{
    internal class CharacterSet
    {
        private List<char> _characters;
        public CharacterSet(IEnumerable<char> characters)
        {
            if (characters == null)
            {
                throw new ArgumentNullException(nameof(characters));
            }

            _characters = new List<char>(characters.Distinct());
        }
        public IEnumerable<char> Characters => _characters;
        public bool IsValidSet()
        {
            return _characters.Count == _characters.Distinct().Count();
        }
        public static CharacterSet operator +(CharacterSet set1, CharacterSet set2)
        {
            var mergedCharacters = set1.Characters.Union(set2.Characters);
            return new CharacterSet(mergedCharacters);
        }
        public static CharacterSet operator -(CharacterSet set1, CharacterSet set2)
        {
            var differenceCharacters = set1.Characters.Except(set2.Characters);
            return new CharacterSet(differenceCharacters);
        }
        public static CharacterSet operator *(CharacterSet set1, CharacterSet set2)
        {
            var intersectionCharacters = set1.Characters.Intersect(set2.Characters);
            return new CharacterSet(intersectionCharacters);
        }
        public static CharacterSet operator ++(CharacterSet set)
        {
           for (int i = 0; i < set._characters.Count; i++)
            {
                set._characters[i]++;
            }

            return set;
        }
        public static bool operator ==(CharacterSet set1, CharacterSet set2)
        {
            if (set1 is null || set2 is null)
            {
                return false;
            }
            if (ReferenceEquals(set1, set2))
            {
                return true;
            }
            return set1.Characters.SequenceEqual(set2.Characters);
        }
        public static CharacterSet operator --(CharacterSet set)
        {
            for (int i = 0; i < set._characters.Count; i++)
            {
                set._characters[i]--;
            }

            return set;
        }
        public static bool operator !=(CharacterSet set1, CharacterSet set2)
        {
            return !(set1 == set2);
        }
        public override bool Equals(object? obj)
        {
            if (obj is CharacterSet otherSet)
            {
                return this == otherSet;
            }

            return false;
        }
        public override int GetHashCode()
        {
            return _characters?.GetHashCode() ?? 0;
        }
        public override string ToString()
        {
            return new string(_characters.ToArray());
        }
        public static explicit operator CharacterSet(string str)
        {
            return new CharacterSet(str);
        }
    }
}
