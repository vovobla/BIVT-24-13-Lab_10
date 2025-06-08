using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Model.Core;

namespace Model.Data
{
    public class XmlSerializer : AbstractSerializer
    {
        public override void Serialize<T>(string filename, T obj)
        {
            using var fs = new FileStream(filename, FileMode.Create);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            serializer.Serialize(fs, obj);
        }

        public override T Deserialize<T>(string filename)
        {
            if (!File.Exists(filename)) return default;
            using var fs = new FileStream(filename, FileMode.Open);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(fs);
        }

        public static List<TrainerDTO> ConvertToDTO(List<Trainer> trainers)
        {
            var list = new List<TrainerDTO>();
            foreach (var t in trainers)
            {
                list.Add(new TrainerDTO
                {
                    FullName = t.FullName,
                    Rating = t.Rating,
                    Groups = t.Groups?.Select(g => new GroupDTO
                    {
                        Name = g.Name,
                        Athletes = g.Athletes?.Select(a => new AthleteDTO
                        {
                            FullName = a.FullName,
                            Age = a.Age,
                            Gender = a.Gender == Gender.Male ? "Мужской" : "Женский"
                        }).ToList()
                    }).ToList()
                });
            }
            return list;
        }
    }

    public class TrainerDTO
    {
        public string FullName { get; set; }
        public double Rating { get; set; }
        public List<GroupDTO> Groups { get; set; }
    }

    public class GroupDTO
    {
        public string Name { get; set; }
        public List<AthleteDTO> Athletes { get; set; }
    }

    public class AthleteDTO
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; } 
    }
}
