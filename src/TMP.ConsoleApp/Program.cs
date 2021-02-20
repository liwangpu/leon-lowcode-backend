using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;

namespace TMP.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://122.51.54.26:27017");
            IMongoDatabase db = dbClient.GetDatabase("tutorial");
            var studentRepository = db.GetCollection<Student>("student");

            //var students = new List<Student>();
            //for (var i = 1; i <= 20; i++)
            //{
            //    var s = new Student();
            //    s.Id = Guid.NewGuid().ToString("N");
            //    s.Name = s.Id;
            //    students.Add(s);
            //}

            //studentRepository.InsertMany(students);

            var filter1 = new BsonDocument { { "Name", "leon" } };

            var filter = "{'Name':{'$regex':'leon'}}";
            var sort = "{'Name':-1}";

            //var st1 = new BsonDocument(filter);


            var res = studentRepository.Find(filter).Sort(sort);
            var list = res.ToList();
            Console.WriteLine(res.Count());

            Console.WriteLine("---complete---");
            Console.ReadKey();
        }
    }

    class Student
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
