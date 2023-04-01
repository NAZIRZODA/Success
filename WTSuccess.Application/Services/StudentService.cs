using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Common.Interfaces;
using WTSuccess.Application.Common.Interfaces.Repositories;
using WTSuccess.Application.Requests;
using WTSuccess.Application.Requests.StudentRequests;
using WTSuccess.Application.Responses.StudentRespones;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Services
{
    public class StudentService : BaseService<Student, StudentResponseModel, StudentRequestModel>, IStudentService
    {
        private readonly IRepository<Student> _repository;
        private readonly IMapper _mapper;
        public StudentService(IRepository<Student> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override void Add(StudentRequestModel request)
        {
            var parsedToCreate = request as CreateStudentRequestModel;
            if (parsedToCreate == null) throw new ArgumentNullException(nameof(Student));
            var mappedToStudent = _mapper.Map<CreateStudentRequestModel, Student>(parsedToCreate);
            _repository.Add(mappedToStudent);
            _repository.SaveChanges();
        }

        public override StudentResponseModel Get(ulong id)
        {
            var dbStudent = _repository.FindById(id);
            if (dbStudent == null) throw new ArgumentNullException(nameof(Student));
            var mappedToResponse = _mapper.Map<Student, StudentResponseModel>(dbStudent);
            return mappedToResponse;
        }

        public override IEnumerable<StudentResponseModel> GetAll(int pageList, int pageNumber)
        {
            var dbStudents = _repository.GetAll(pageList, pageNumber);
            var mappedToRespones = _mapper.Map<IEnumerable<Student>, IEnumerable<StudentResponseModel>>(dbStudents);
            return mappedToRespones;
        }

        public override StudentResponseModel Update(ulong id, StudentRequestModel request)
        {
            var dbStudent = _repository.FindById(id);
            if (dbStudent == null) throw new ArgumentNullException(nameof(Student));
            var studentRequestToUpdate = request as UpdateStudentRequestModel;
            dbStudent.Name = studentRequestToUpdate.Name;
            dbStudent.Surname = studentRequestToUpdate.Surname;
            dbStudent.Email = studentRequestToUpdate.Email;
            dbStudent.Password = studentRequestToUpdate.Password;
            _repository.Update(dbStudent);
            _repository.SaveChanges();
            return _mapper.Map<UpdateStudentRequestModel, StudentResponseModel>(studentRequestToUpdate);
        }

        public override bool Delete(ulong id)
        {
            var dbStudent = _repository.FindById(id);
            if (dbStudent == null) throw new ArgumentNullException(nameof(Student));
            _repository.Delete(dbStudent);
            _repository.SaveChanges();
            return true;
        }

    }
}
