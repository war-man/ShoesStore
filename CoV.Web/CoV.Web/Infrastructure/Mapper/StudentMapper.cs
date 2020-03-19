using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    /// <summary>
    /// this class create Mapper Student with classes viewmodel
    /// </summary>
    public class StudentMapper :Profile
    {
        /// <summary>
        /// COntructor Student profile  Map classes to Classes viewmodel 
        /// </summary>
        public StudentMapper()
        {
            CreateMap<StudentViewModel, Student>();    
            CreateMap<Student, StudentViewModel>();
        }     
    }
}