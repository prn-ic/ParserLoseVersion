using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonParcer
{

    class ParserEnumerator: IEnumerator<Person>
    {
       
        TextFieldParser textFieldParser;
       
        int position = -1;
        public ParserEnumerator(TextFieldParser textFieldParser) => this.textFieldParser = textFieldParser;

        public Person Current
        {
            get;
            private set;
        }

        object IEnumerator.Current => throw new NotImplementedException();
        public bool MoveNext()
        {
            if (textFieldParser.EndOfData != true)
            {
                position++;
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.SetDelimiters(",");
                List<string> person = textFieldParser.ReadFields().ToList();
                Current = new Person
                {
                    Id = int.Parse(person[0]),
                    FirstName = person[1],
                    LastName = person[2],
                    Email = person[3],
                    Age = int.Parse(person[4]),
                    Profession = person[5]
                };
                return true;
            }
            else
            {
                return false;
            }


        }

        public void Reset() => position -= 1;
        public void Dispose() { }

    }

    class Parser
    {
        TextFieldParser textFieldParser;
        public Parser(TextFieldParser textFieldParser) => this.textFieldParser = textFieldParser;
        public IEnumerator<Person> GetEnumerator() => new ParserEnumerator(textFieldParser);
    }
    
}
