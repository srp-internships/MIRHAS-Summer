﻿namespace Practice.Models.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Teacher? Teacher { get; set; }
        public List<Student>? Students { get; set; }
    }
}
