using EveOnlineFittingAssistant_Data;
using EveOnlineFittingAssistant_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveOnlineFittingAssistant_Services
{
    public class FitService
    {
        public bool Create(FitModel fit)
        {
            var entity = new Fit()
            {
                ShipId = fit.ShipId,
                HighModuleIds = fit.HighModuleIds,
                MidModuleIds = fit.MidModuleIds,
                LowModuleIds = fit.LowModuleIds
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Fits.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<FitModel> GetAllFits()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Fits
                    .Select(
                        e =>
                        new FitModel()
                        {
                            Id = e.Id,
                            ShipId = e.ShipId,
                            HighModuleIds = e.HighModuleIds,
                            MidModuleIds = e.MidModuleIds,
                            LowModuleIds = e.LowModuleIds
                        });
                return query.ToList();
            }
        }
        public FitModel GetFitById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var fit =
                    ctx
                    .Fits
                    .Single(
                        e => e.Id == id
                    );
                return new FitModel()
                {
                    Id = fit.Id,
                    ShipId = fit.ShipId,
                    HighModuleIds = fit.HighModuleIds,
                    MidModuleIds = fit.MidModuleIds,
                    LowModuleIds = fit.LowModuleIds
                };
            }
        }
        public bool UpdateFit(int id, FitModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var Fit = ctx.Fits.Single(e => e.Id == id);
                Fit.LowModuleIds = model.LowModuleIds;
                Fit.MidModuleIds = model.MidModuleIds;
                Fit.HighModuleIds = model.HighModuleIds;
                Fit.ShipId = model.ShipId;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
