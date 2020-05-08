using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MBook.Models
{
    public class Book
    {
        public string Name {get;set;}
        public string Genre {get;set;}
        public bool isSerie {get;set;}
        public int SerieId {get;set;}
        public int Volume {get;set;}
        public List<Chapter> Chapters {get;set;}
        public string CoverPath {get;set;}
        public string Resume {get;set;}
        public string License {get;set;}
        public string LastEdit {get;set;}
        public IFormFile Cover{get;set;}        
    }

    public class Chapter
    {
        public int ChapterNumber {get;set;}
        public string Content {get;set;}
        public List<Character> Characters {get;set;}
        public List<Place> Places {get;set;}
        public List<Object> Objects {get;set;}
    }
    
    public class Character
    {
        public int CharacterId {get;set;}
        public string Name {get;set;}
        public int Age {get;set;}
        public string Birthday {get;set;}
        public string Motivation {get;set;}
        public string Role {get;set;}
        public List<Characteristic> Characteristics {get;set;}
    }
    public class Characteristic
    {
        public string Name {get;set;}
        public string Value {get;set;}
    }
    public class Place
    {
        public string Name {get;set;}
        public string Country {get;set;}
        public string Location {get;set;}
        public List<Characteristic> Characteristics {get;set;}
    }
}