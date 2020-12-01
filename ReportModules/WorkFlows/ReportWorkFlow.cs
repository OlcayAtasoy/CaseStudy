using AutoMapper;
using DirectoryModules.Contracts;
using DirectoryModules.RequestModels;
using DirectoryModules.ResponseModels;
using Infrastructure.CoreQueue.Model;
using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Enum;
using Infrastructure.DataModel.Interface;
using ReportModules.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DirectoryModules.WorkFlows
{
    public class ReportWorkFlow : IReportContract
    {
        IReportRepository _reportRepository;
        IDirectoryRepository _directoryRepository;
        ICommunicationInformationRepository _communicationInformationRepository;
        MyDbContext _context;
        public ReportWorkFlow(IReportRepository reportRepository,
            IDirectoryRepository directoryRepository,
            ICommunicationInformationRepository communicationInformationRepository,
            MyDbContext context)
        {
            _reportRepository = reportRepository;
            _directoryRepository = directoryRepository;
            _communicationInformationRepository = communicationInformationRepository;
            _context = context;

        }
        public bool GetReport(ReportsRequestModel request)
        {
            bool response = false;

            var LocationPersonCount = _communicationInformationRepository.Table.Where(x => x.IsDeleted == false && x.InformationTypeId == (int)EnumInformationType.Location).GroupBy(f => f.InformationContent).Count();
            var LocationPhoneCount = _communicationInformationRepository.Table.Where(x => x.IsDeleted == false && (x.InformationTypeId == (int)EnumInformationType.PhoneNumber) && (x.InformationTypeId == (int)EnumInformationType.Location)).GroupBy(f => f.InformationContent).Count();

            Reports reports = _reportRepository.Table.Where(x => x.ReportServiceStatus == (int)EnumReportServiceStatus.Hazirlaniyor && x.ReportDate ==request.ReportDate).FirstOrDefault();
            reports.PersonCount = LocationPersonCount;
            reports.PhoneNumberCount = LocationPhoneCount;
            reports.ReportServiceStatus = (int)EnumReportServiceStatus.Hazirlaniyor;
            reports.ReportStatus = "Tamamlandi";

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _reportRepository.Update(reports);

                    transaction.Commit();
                    response = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }

            return response;
        }

        public object GetReportsListData()
        {
            var query = (from reports in _reportRepository.Table
                         select new ReportResponseModel
                         {
                             Id = reports.Id,
                             PersonCount = reports.PersonCount,
                             PhoneNumberCount = reports.PhoneNumberCount,
                             ReportDate = reports.ReportDate,
                             ReportLocation = reports.ReportLocation,
                             ReportServiceStatus = reports.ReportServiceStatus,
                             ReportStatus = reports.ReportStatus

                         });

            return query;
        }
    }
}
