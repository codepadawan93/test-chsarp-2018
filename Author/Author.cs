using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    class Author : IComparable<Object>, ICloneable
    {
        public String Name { get; set; }
        public String[] Publications { get; set; }
        private readonly int PublicationCount;

        public Author(String name, String[] publications)
        {
            Name = name;
            Publications = publications;
            PublicationCount = publications.Count();
        }

        public override string ToString()
        {
            StringBuilder retval = new StringBuilder();
            retval.Append("Name: " + Name + "\r\n");
            retval.Append("Publications: ");
            foreach(string publication in Publications)
            {
                retval.Append(publication + ", ");
            }
            retval.Append("\r\n");
            retval.Append("Number of publications: " + PublicationCount);
            retval.Append("\r\n");
            return retval.ToString();
        }

        public int CompareTo(object other)
        {
            if (other is Author)
            {
                Author compared = (Author)other;
                if (compared.PublicationCount > PublicationCount)
                {
                    return -1;
                }
                else if (compared.PublicationCount < PublicationCount)
                {
                    return 1;
                }
                else
                {
                    return string.Compare(compared.Name, Name);
                }
            }
            else {
                throw new Exception("Not comparable because not instance of Author");
            }
        }

        public object Clone()
        {
            return new Author(Name, Publications);
        }

        public static implicit operator int(Author auth)
        {
            return auth.PublicationCount;
        }
    }
}
