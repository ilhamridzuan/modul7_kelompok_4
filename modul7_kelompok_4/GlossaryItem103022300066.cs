using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class GlossaryItem103022300066
    {
        public class GlossEntry
        {
            public string ID { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public string GlossDef { get; set; }
            public string GlossSee { get; set; }
        }
        public class GlossDef
        {
            public string para { get; set; }
        }
        public class GlossList
        {
            public List<GlossEntry> GlossEntry { get; set; }
        }
        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }
        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }   

        public class GlossaryRoot
        {
            public Glossary glossary { get; set; }
        }
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("../../../jurnal7_103022300066.json");
            var glossaryRoot = JsonSerializer.Deserialize<GlossaryRoot>(jsonString);

            var entrys = glossaryRoot.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine($"Title: {glossaryRoot.glossary.title}");
            Console.WriteLine($"GlossDiv Title: {glossaryRoot.glossary.GlossDiv.title}");
            Console.WriteLine("Glossary Entries:");
            foreach (var entry in entrys)
            {
                Console.WriteLine($"ID: {entry.ID}");
                Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
                Console.WriteLine($"Acronym: {entry.Acronym}");
                Console.WriteLine($"Abbrev: {entry.Abbrev}");
                Console.WriteLine($"GlossDef: {entry.GlossDef}");
                Console.WriteLine($"GlossSee: {entry.GlossSee}");
                Console.WriteLine();
            }
        }
    }
}