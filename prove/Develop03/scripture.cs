using System;
using System.Collections.Generic;

namespace Develop03{

    public class Scripture{

        public List<string> verse;
        public List<string> givenScripture(){
            //verse = new List<string>();
            string script = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            IList<string> verses = script.Split(" ");

            return verse;
        }
    }
}