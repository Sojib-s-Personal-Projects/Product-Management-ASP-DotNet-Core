﻿using AutoMapper;
using Infrastructure.BusinessObjects;
using Infrastructure.DbContexts;
using Infrastructure.Entities;
using Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerBO = Infrastructure.BusinessObjects.Worker;
using WorkerEO = Infrastructure.Entities.Worker;

namespace Infrastructure.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        private readonly IMapper _mapper;

        public WorkerService(IApplicationUnitOfWork applicationUnitOfWork, IMapper mapper)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
            _mapper = mapper;
        }

        public async Task<(int total, int totalDisplay, IList<WorkerBO> records)> GetDashboardInfo(int pageIndex, int pageSize, string searchText, string orderby)
        {
            (IList<WorkerEO> data, int total, int totalDisplay) results = _applicationUnitOfWork
                .Workers.GetDashBoardInfo(pageIndex, pageSize, searchText, orderby);

            IList<WorkerBO> workers = new List<WorkerBO>();
            foreach (WorkerEO workerEO in results.data)
            {
                var workerBO = _mapper.Map<WorkerBO>(workerEO);
                workers.Add(workerBO);
            }
            results.total = workers.Count();
            results.totalDisplay = workers.Count();
            return (results.total, results.totalDisplay, workers);
        }

        public (int total, int totalDisplay, IList<WorkerBO> records) GetWorkers(int pageIndex,
            int pageSize, string searchText, string orderby)
        {
            (IList<WorkerEO> data, int total, int totalDisplay) results = _applicationUnitOfWork
                .Workers.GetWorkers(pageIndex, pageSize, searchText, orderby);

            IList<WorkerBO> workers = new List<WorkerBO>();
            foreach (WorkerEO workerEO in results.data)
            {
                if (workerEO.WorkerInfo == null)
                {
                    workers.Add(new WorkerBO
                    {
                        Id = workerEO.Id,
                        Name = workerEO.Name,
                        FathersName = workerEO.FathersName,
                        MothersName = workerEO.MothersName,
                        Roll = workerEO.Roll,
                        User = workerEO.User,
                        PermanentDistrict = workerEO.PermanentDistrict,
                        PostName = workerEO.PostName,
                        Quota = workerEO.Quota,
                        DateOfBirth = workerEO.DateOfBirth
                    });
                }
            }
            //results.total = workers.Count();
            results.totalDisplay = workers.Count();
            return (results.total, results.totalDisplay, workers);
        }
    }
}
