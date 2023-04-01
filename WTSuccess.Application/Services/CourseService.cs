using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Common.Interfaces;
using WTSuccess.Application.Common.Interfaces.Repositories;
using WTSuccess.Application.Requests.CourseRequests;
using WTSuccess.Application.Requests.StudentRequests;
using WTSuccess.Application.Responses.ChapterRespones;
using WTSuccess.Application.Responses.CourseRespnses;
using WTSuccess.Application.Responses.StudentRespones;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Services
{
    public class CourseService : BaseService<Course, CourseResponseModel, CourseRequestModel>, ICourseService
    {
        private readonly IRepository<Course> _repository;
        private readonly IMapper _mapper;
        public CourseService(IRepository<Course> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override void Add(CourseRequestModel request)
        {
            var parsedToCreate = request as CreateCourseRequestModel;
            if (parsedToCreate == null) throw new ArgumentNullException(nameof(Course));
            var mappedToChapter = _mapper.Map<CreateCourseRequestModel, Course>(parsedToCreate);
            _repository.Add(mappedToChapter);
            _repository.SaveChanges();
        }

        public override CourseResponseModel Get(ulong id)
        {
            var dbChapter = _repository.FindById(id);
            if (dbChapter == null) throw new ArgumentNullException(nameof(Course));
            var mappedToResponse = _mapper.Map<Course, CourseResponseModel>(dbChapter);
            return mappedToResponse;
        }

        public override IEnumerable<CourseResponseModel> GetAll(int pageList, int pageNumber)
        {
            var dbCourse = _repository.GetAll(pageList, pageNumber);
            var mappedToRespones = _mapper.Map<IEnumerable<Course>, IEnumerable<CourseResponseModel>>(dbCourse);
            return mappedToRespones;
        }

        public override CourseResponseModel Update(ulong id, CourseRequestModel request)
        {
            var dbCourse = _repository.FindById(id);
            if (dbCourse == null) throw new ArgumentNullException(nameof(Course));
            var courseRequestToUpdate = request as UpdateCourseRequestModel;
            dbCourse.Name = courseRequestToUpdate.Name;
            dbCourse.Chapters = courseRequestToUpdate.Chapters;
            dbCourse.Students = courseRequestToUpdate.Students;
            _repository.Update(dbCourse);
            _repository.SaveChanges();
            return _mapper.Map<UpdateCourseRequestModel, CourseResponseModel>(courseRequestToUpdate);
        }

        public override bool Delete(ulong id)
        {
            var dbCourse = _repository.FindById(id);
            if (dbCourse == null) throw new ArgumentNullException(nameof(Course));
            _repository.Delete(dbCourse);
            _repository.SaveChanges();
            return true;
        }
    }
}
