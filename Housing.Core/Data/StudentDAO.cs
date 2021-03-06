﻿using System.Configuration;
using System.Data.SqlClient;
using UWHousing.Entities.Persistence;
using Dapper;
using UWHousing.Entities.DTO;
using UWHousing.Entities.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;

namespace UWHousing.Data
{
    /// <summary>
    /// Data access object for students 
    /// </summary>
    public class StudentDAO
    {

        /// <summary>
        /// Creates a new student
        /// </summary>
        public void CreateStudent(StudentDTO newstudentDTO)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UWHousing"].ConnectionString)) //placeholder
            {
                connection.Open();
                string sql = @"Insert INTO Student (StudentID, 
                               Firstname,
                               Lastname, 
                               Buildingname,
                               Roomnumber)
                               
                               Values (@StudentID, @Firstname, @Lastname, @Buildingname, @Roomnumber)";


                connection.Execute(sql, newstudentDTO);
            }

        }
        public string GetStudent(long StudentID)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UWHousing"].ConnectionString)) //placeholder
            {
                connection.Open();
                string sql = @"SELECT Firstname + ' ' + Lastname
                        FROM Student
                        WHERE StudentID = @StudentID;";
                return (string)connection.ExecuteScalar(sql, new {StudentID});
                

            }

        }

    }
}
