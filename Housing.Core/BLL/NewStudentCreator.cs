﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWHousing.Data;
using UWHousing.Entities.DTO;
using UWHousing.Entities.Persistence;
namespace UWHousing.BLL
{
    /// <summary>
    /// Business object responsible for creating new students in the system
    /// </summary>
    public class NewStudentCreator
    {
        private readonly StudentDAO _studentDAO;


        public NewStudentCreator()
        {
            _studentDAO = new StudentDAO();

        }

        /// <summary>
        /// Creates a new student
        /// </summary>
        public void CreateStudent(NewStudentDTO newStudentDTO)
        {
            // create the studentDTO for persistence and populate its properties
            StudentDTO studentDTO = new StudentDTO()
            {
                StudentID = newStudentDTO.StudentID,
                Firstname = newStudentDTO.Firstname,
                Lastname = newStudentDTO.Lastname,
                Buildingname = newStudentDTO.Buildingname,
                Roomnumber = newStudentDTO.Roomnumber,
            };
           
        }
    }
}
