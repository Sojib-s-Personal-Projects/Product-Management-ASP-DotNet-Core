﻿using Infrastructure.Entities;
using DashBoardInfoBO = Infrastructure.BusinessObjects.DashBoardInfo;
namespace Infrastructure.Repositories
{
    public interface IWorkerRepository: IRepository<Worker, Guid>
    {
        //Task<(IList<DashBoardInfoBO> data, int total, int totalDisplay)> GetDashBoardInfo(int pageIndex, int pageSize, string searchText, string orderby);
        (IList<Worker> data, int total, int totalDisplay) GetWorkers(int pageIndex,
        int pageSize, string searchText, string orderby);
        (IList<Worker> data, int total, int totalDisplay) GetDashBoardInfo(int pageIndex,
        int pageSize, string searchText, string orderby);
    }
}