using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    private static readonly List<Project> Projects = new()
    {
        new Project
        {
            Id = 1,
            Image = "p2Pic.png",
            Title = "Education Platform",
            Description = "Developed Education Platform, a TypeScript and React-based website designed to help young people choose an education, as part of my second-semester Computer Science project.",
            Details = "Developed Education Platform as part of my second-semester Computer Science project. The platform is a web application built with TypeScript and React, designed to help young people explore and choose suitable educational paths. It features a user-friendly interface for browsing various educational programs, providing detailed information and resources to guide decision-making. My main responsibilities included API integration with multiple services such as OpenAI and Cortical.IO, as well as developing a web scraper to collect the necessary text data. Additionally, I implemented a calculation system to score subjects based on their connection to mathematics, using a mix of TypeScript and Python. The project aims to make the process of selecting an education more accessible and informed for users.",
            Link = new[] { "https://github.com/P2-API/Education-Platform" }
        },
        new Project
        {
            Id = 2,
            Image = "Tutorly.svg",
            Title = "Tutorly",
            Description = "Developed Tutorly as my third-semester Computer Science project, a platform created in collaboration with Hasseris Gymnasium to support tutor-tutee relationships, featuring a Java backend and a TypeScript React frontend.",
            Details = "Contributed as part of a team in the development of Tutorly during my third semester, a platform created in collaboration with Hasseris Gymnasium to support tutor-tutee relationships. My primary responsibility was working on the backend, where I helped develop core functionalities using object-oriented programming principles with Spring Java and a MySQL database. I also handled pull requests for both the backend and frontend, ensuring smooth integration. The frontend utilized TypeScript with React, providing an efficient and user-friendly platform for managing tutor-tutee interactions.",
            Link = new[] { "https://github.com/P3-HasserisGymnasium/Tutor-Administration-Platform" }
        },
        new Project
        {
            Id = 3,
            Image = "foodDonations.jpg",
            Title = "P2P Food Donation",
            Description = "Developed P2P Food Donations, a C-based program enabling peer-to-peer food donation coordination, as part of my first-year Computer Science semester project.",
            Details = "Developed P2P Food Donations as my first university project, a terminal-based program enabling peer-to-peer food donation coordination. My main responsibility was implementing the login flow, ensuring secure access for users. This project provided an introduction to programming concepts and terminal-based interfaces in a real-world application.",
            Link = new[] { "https://github.com/P1-P2P-Food-donation/P2P-Food-Donation" }
        },
        new Project
        {
            Id = 4,
            Image = "Mywebsite.jpg",
            Title = "My Website",
            Description = "Created a personal hobby project: a website about myself, featuring a C# backend and a Vue.js frontend written in TypeScript.",
            Details = "Developed a personal website to promote the projects I’ve worked on and showcase my capabilities. The website is built using Vue.js with TypeScript for the frontend, while the backend is powered by C#, ensuring a fast and scalable experience for users.",
            Link = new[] { "https://github.com/EmilVorre/AboutMeWebsite" }
        },
        new Project
        {
            Id = 5,
            Image = "Twitch.png",
            Title = "Twitch View Prediction",
            Description = "Currently developing a hobby project combining web scraping and machine learning to create a program that predicts Twitch viewer counts for specific categories.",
            Details = "Currently developing a hobby project to predict Twitch viewer counts for specific categories, built to challenge myself in web scraping, integrating multiple languages into one program, and exploring machine learning. The data processing is written in Rust, the web scraper in Go, the website frontend in Vue.js with TypeScript, and the backend in Python. The program scrapes relevant data and uses machine learning algorithms to analyze trends and make predictions, helping users anticipate viewer engagement for different streams. This project is still under development and aims to improve predictions with more refined models over time.",
            Link = new[] { "https://github.com/EmilVorre/TwitchViewerPredictionApp" }
        },
        new Project
        {
            Id = 6,
            Image = "dart.jpg",
            Title = "Dart Tournament Organizer",
            Description = "Created a Dart Tournament Organizer for a dart club, which are Python-based application with a random matchmaking system and a simple user interface to streamline tournament management.",
            Details = "Developed a Dart Tournament Organizer for a dart club in Denmark, a Python-based application designed to streamline the management of dart tournaments. The program includes a random matchmaking system and a simple user interface, making it easy to organize and track tournament progress. This project aimed at providing a more efficient and automated way to handle dart competitions.",
            Link = new[] { "https://github.com/EmilVorre/DartTournamentOrganizer" }
        },
    };

    [HttpGet]
    public IEnumerable<Project> GetAllProjects() => Projects;

    [HttpGet("{id}")]
    public ActionResult<Project> GetProjectById(int id)
    {
        var project = Projects.FirstOrDefault(p => p.Id == id);
        if (project == null)
        {
            return NotFound(new { message = "Project not found" });
        }
        return project;
    }
}

public class Project
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Details { get; set; }
    public string[] Link { get; set; }
}
