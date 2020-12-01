using AutoMapper;
using DirectoryModules.Contracts;
using DirectoryModules.RequestModels;
using DirectoryModules.ResponseModels;
using Infrastructure.CoreQueue;
using Infrastructure.CoreQueue.Model;
using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Enum;
using Infrastructure.DataModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DirectoryModules.WorkFlows
{
    public class DirectoryWorkFlow : IDirectoryContract
    {
        IMapper _mapper;
        IDirectoryRepository _directoryRepository;
        ICommunicationInformationRepository _communicationInformationRepository;
        MyDbContext _context;
        IReportRepository _reportRepository;
        public DirectoryWorkFlow(IMapper mapper,
            IDirectoryRepository directoryRepository,
            ICommunicationInformationRepository communicationInformationRepository,
            MyDbContext context,
            IReportRepository reportRepository)
        {
            _mapper = mapper;
            _directoryRepository = directoryRepository;
            _communicationInformationRepository = communicationInformationRepository;
            _context = context;
            _reportRepository = reportRepository;

        }
        public DirectoryResponseModel CreateDirection(DirectionCreateRequestModel request)
        {
            DirectoryResponseModel response = new DirectoryResponseModel();

            Directory directory = _mapper.Map<DirectionCreateRequestModel, Directory>(request);

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _directoryRepository.Insert(directory);


                    if (request.CommunicationInformation != null && request.CommunicationInformation.Any())
                    {
                        foreach (var item in request.CommunicationInformation)
                        {
                            CommunicationInformation communicationInformation = _mapper.Map<CommunicationInformationRequestModel, CommunicationInformation>(item);

                            communicationInformation.DirectoryId = directory.Id;

                            _communicationInformationRepository.Insert(communicationInformation);
                        }
                    }

                    transaction.Commit();
                    response.Message = "Ok";
                    response.Status = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    response.Message = ex.Message;
                    response.Status = false;
                    throw ex;
                }
            }

            return response;
        }
        public DirectoryResponseModel RemoveDirection(DirectionRemoveRequestModel request)
        {
            DirectoryResponseModel response = new DirectoryResponseModel();

            request.CommunicationInformation = request.CommunicationInformation == null ? null : request.CommunicationInformation.Where(x => x.ChangeState != ChangeState.UnChanged).ToList();

            if (request.CommunicationInformation != null && request.CommunicationInformation.Any(x => x.ChangeState == ChangeState.Deleted))
            {
                foreach (var communicationInformation in request.CommunicationInformation.Where(x => x.ChangeState == ChangeState.Deleted))
                {
                    communicationInformation.IsDeleted = true;
                    communicationInformation.ChangeState = ChangeState.Updated;
                }
            }

            Directory directory = _directoryRepository.GetDirectoryWithRelations(request.Id);
            directory.IsDeleted = true;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _directoryRepository.Update(directory);

                    if (request.CommunicationInformation != null && request.CommunicationInformation.Any(x => x.ChangeState == ChangeState.Deleted))
                    {
                        foreach (CommunicationInformationRemoveRequestModel item in request.CommunicationInformation.Where(x => x.ChangeState == ChangeState.Deleted))
                        {
                            CommunicationInformation communicationInformation = _communicationInformationRepository.Table.Where(x => x.DirectoryId == directory.Id).FirstOrDefault();

                            _communicationInformationRepository.Update(communicationInformation);
                        }
                    }
                    transaction.Commit();
                    response.Message = "Ok";
                    response.Status = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    response.Message = ex.Message;
                    response.Status = false;
                    throw ex;
                }
            }

            return response;
        }
        public object GetDirectoryListGridData()
        {
            var query = (from directory in _directoryRepository.Table
                         select new GetDirectoryListResponseModel
                         {
                             Company = directory.Company,
                             Name = directory.Name,
                             Surname = directory.Surname,
                         });

            return query;
        }
        public object GetCommunicationInformationListGridData(GetCommunicationInformationListGridDataRequestModel requestModel)
        {
            var query = (from directory in _directoryRepository.Table
                         join communicationInformation in _communicationInformationRepository.Table.Where(m => m.IsDeleted == false) on directory.Id equals communicationInformation.DirectoryId into tmpCommunicationInformation
                         from communicationInformation in tmpCommunicationInformation.DefaultIfEmpty()
                         where communicationInformation.DirectoryId == requestModel.DirectoryId
                         select new GetCommunicationInformationListGridDataResponseModel
                         {
                             Id = communicationInformation != null ? communicationInformation.Id : null,
                             InformationContent = communicationInformation != null ? communicationInformation.InformationContent : string.Empty,
                             InformationTypeName = (communicationInformation.InformationTypeId == 1 ? EnumInformationType.PhoneNumber : (communicationInformation.InformationTypeId == 2 ? EnumInformationType.Email : EnumInformationType.Location)).ToString(),
                             IsDeleted = communicationInformation != null ? communicationInformation.IsDeleted : false,
                         });

            return query;
        }

        public bool ExecuteReportJob(ReportsRequestModel requestModel)
        {
            bool response = false;
            if (requestModel.ReportRequest == true)
            {
                var publisher = new Publisher();
                var result = publisher.Publish("ReportJob", requestModel);
                if (!result)
                {
                    Reports reports = new Reports();
                    reports.ReportStatus = "Hazırlanıyor";
                    reports.ReportDate = requestModel.ReportDate;
                    reports.ReportServiceStatus = (int)EnumReportServiceStatus.Hazirlaniyor;

                    _reportRepository.Insert(reports);
                }
                response = true;
            }

            return response;
        }

    }
}
